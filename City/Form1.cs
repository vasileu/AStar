using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City
{
    public partial class Form1 : Form
    {
        private Location[] _locations;
        private Graph _graph;
        private int _rowCount;
        private int _columnCount;

        private int _locationSizeX;
        private int _locationSizeY;

        private int _levelCount = 20; // < 510 !!!!!!!!!!!!;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            _rowCount = int.Parse(rowCountEdit.Text);
            _columnCount = int.Parse(columnCountEdit.Text);

            int vertexCount = _rowCount * _columnCount;
            _graph = new Graph(vertexCount, false);
            _locations = generateCity(_columnCount, _rowCount, _graph);
            paintCity();
            
        }

        private void redrawLocation(int index, Color color)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.FillEllipse(new SolidBrush(color), 
                                    _locations[index].x + _locationSizeX - 15, 
                                    _locations[index].y + _locationSizeY - 15, 
                                    10, 
                                    10);
            
        }


        private void paintCity()
        {
            Pallete pallete = new Pallete(_levelCount);
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black);

            //draw locations
            foreach( Location location in _locations){
                graphics.DrawRectangle(pen, location.x, location.y, _locationSizeX, _locationSizeY);
                if (coloringCheckBox.Checked)
                {
                    graphics.FillRectangle(new SolidBrush(pallete.getColor(_levelCount - location.value)), 
                                                location.x, 
                                                location.y, 
                                                _locationSizeX, 
                                                _locationSizeY);
                }
                graphics.DrawString(location.value.ToString(), 
                                    System.Drawing.SystemFonts.CaptionFont, 
                                    new SolidBrush(Color.MediumBlue), 
                                    location.x, 
                                    location.y);
            }
        }

        private Location[] generateCity(int cols, int rows, Graph graph)
        {
            if (cols < 2 || rows < 2)
                throw new ArgumentOutOfRangeException("rows || cols");

            Random rand = new Random();
            
            //generate locations
            Location[] result = new Location[rows * cols];

            _locationSizeX = 800 / (cols + 2);
            _locationSizeY = 600 / (rows + 2);

            int y = _locationSizeY;
            for (int i = 0; i < rows; i++)
            {
                int x = _locationSizeX;
                for (int j = 0; j < cols; j++)
                {
                    int value = rand.Next(_levelCount);
                    result[i * cols + j] = new Location(x, y, value);
                    x += _locationSizeX;
                }
                y += _locationSizeY;
            }


            //generate roads
            int[,] delta = {               {0, -1},  
                                {-1, 0},            {1, 0}, 
                                           {0, 1},  
                           };
            
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int outRoadCount = 4; 
                    for (int road = 0; road < outRoadCount; road++)
                    {
                        int destI = i + delta[road, 0];
                        int destJ = j + delta[road, 1];
                        if (isIndexValid(destI, cols) && isIndexValid(destJ, rows))
                        {
                            _graph.insertEdge(new Edge(j * cols + i, destJ * cols + destI, 1));
                        }
                     }
                }
            }

            return result;
        }

        private bool isIndexValid(int index, int elemCount)
        {
            return 0 <= index && index < elemCount;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            paintCity();
            int startStreet = int.Parse(startRowEdit.Text);
            int startAvenue = int.Parse(startColumnBox1.Text);
            int finishStreet = int.Parse(finishRowEdit.Text);
            int finishAvenue = int.Parse(finishColumnEdit.Text);
            int koeff = int.Parse(KoeffEdit.Text);
            int startIndex = startStreet * _columnCount + startAvenue;
            int finishIndex = finishStreet * _columnCount + finishAvenue;
            AStar a = new AStar();
            List<int> path = a.findPath(_graph,_locations, startIndex, finishIndex, _columnCount, koeff);
            if (drawOpened.Checked)
            {
                List<int> opened = a.opened();
                foreach (int location in opened)
                {
                    redrawLocation(location, Color.Yellow);
                }
                openedCountLbl.Text = string.Format("Число открытых вершин : {0}", opened.Count);
            }
            foreach (int location in path)
            {
                redrawLocation(location, Color.Green);
            }
            redrawLocation(startIndex, Color.Blue);
            redrawLocation(finishIndex, Color.Violet);
            totalWageLbl.Text = a.totalWeight().ToString();
            heightDiffLbl.Text = string.Format("Общий перепад высот : {0}", a.totalHeightDiff().ToString());
            lengthLbl.Text = string.Format("Длина маршрута : {0}", path.Count); 
        }


    }
}
