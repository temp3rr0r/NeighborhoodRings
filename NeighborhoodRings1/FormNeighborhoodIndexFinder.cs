using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NeighborhoodRings1
{
    public partial class FormNeighborhoodIndexFinder : Form
    {
        public FormNeighborhoodIndexFinder()
        {
            InitializeComponent();
        }

        private void FormNeighbourIndexFinder_Load(object sender, EventArgs e)
        {
            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            cbCellCountX.SelectedIndex = 0;
            cbCellCountY.SelectedIndex = 0;
        }

        private int GetCellCount(int cellCountX, int cellCountY)
        {
            return cellCountX * cellCountY;
        }
        
        private int GetMaxNeighbourhoodRings(int cellCountX, int cellCountY)
        {
            return Math.Max(cellCountX - 1, cellCountY - 1);
        }
        
        private List<CellPoint> GetNeighboursIndicesList(int cellX, int cellY, int neighbourRing)
        {
            HashSet<CellPoint> returningCellNeighbourseHashSet = new HashSet<CellPoint>();

            int cellCountX;
            int cellCountY;
            if (Int32.TryParse(cbCellCountX.Text, out cellCountX) &&
                Int32.TryParse(cbCellCountY.Text, out cellCountY))
            {

                CellPoint topLeft = new CellPoint
                {
                    X = cellX - neighbourRing,
                    Y = cellY - neighbourRing
                };
                CellPoint topRight = new CellPoint
                {
                    X = cellX - neighbourRing,
                    Y = cellY + neighbourRing
                };
                CellPoint bottomLeft = new CellPoint
                {
                    X = cellX + neighbourRing,
                    Y = cellY - neighbourRing
                };
                CellPoint bottomRight = new CellPoint
                {
                    X = cellX + neighbourRing,
                    Y = cellY + neighbourRing
                };
                
                if (topLeft.X >= 0)
                {
                    int y = topLeft.Y + 1;
                    if (y < 0)
                        y = 0;
                    int maxY = topRight.Y;
                    if (maxY > cellCountY)
                        maxY = cellCountY;
                    for (; y < maxY; y++) // Skips the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = topLeft.X, Y = y}; // Top row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }

                if (bottomLeft.X >= 0)
                {
                    int y = bottomLeft.Y + 1;
                    if (y < 0)
                        y = 0;
                    int maxY = bottomRight.Y;
                    if (maxY > cellCountY)
                        maxY = cellCountY;
                    for (; y < maxY; y++) // Skips the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = bottomLeft.X, Y = y}; // Bottom row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }

                if (topLeft.Y >= 0)
                {
                    int x = topLeft.X;
                    if (x < 0)
                        x = 0;
                    int maxX = bottomLeft.X;
                    if (maxX > cellCountX)
                        maxX = cellCountX;
                    for (; x <= maxX; x++) // Adds all the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = x, Y = topLeft.Y}; // Left row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }

                if (topRight.Y >= 0)
                {
                    int x = topRight.X;
                    if (x < 0)
                        x = 0;
                    int maxX = bottomRight.X;
                    if (maxX > cellCountX)
                        maxX = cellCountX;
                    for (; x <= maxX; x++) // Adds all the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = x, Y = topRight.Y}; // Right row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }
            }

            return new List<CellPoint>(returningCellNeighbourseHashSet);
        }

        private bool IsPointInGrid(CellPoint currentCellPoint, int cellCountX, int cellCountY)
        {
            bool returningIsInGrid = currentCellPoint.X >= 0 && currentCellPoint.Y >= 0 & currentCellPoint.X < cellCountX &&
                currentCellPoint.Y < cellCountY;

            return returningIsInGrid;
        }

        private void UpdateControls()
        {
            int cellCountX;
            int cellCountY;
            if (Int32.TryParse(cbCellCountX.Text, out cellCountX) &&
                Int32.TryParse(cbCellCountY.Text, out cellCountY))
            {
                if (cellCountX > 0 && cellCountY > 0)
                {
                    txtCellCount.Text = GetCellCount(cellCountX, cellCountY).ToString();

                    int maxNeighbourRings = GetMaxNeighbourhoodRings(cellCountX, cellCountY);

                    cbNeighbourRing.Items.Clear();
                    for (int i = 1; i <= maxNeighbourRings; i++)
                        cbNeighbourRing.Items.Add(i);
                    if (cbNeighbourRing.Items.Count > 0)
                        cbNeighbourRing.SelectedIndex = 0;

                    cbCellIndexI.Items.Clear();
                    for (int i = 0; i < cellCountX; i++)
                        cbCellIndexI.Items.Add(i);
                    if (cbCellIndexI.Items.Count > 0)
                        cbCellIndexI.SelectedIndex = 0;

                    cbCellIndexJ.Items.Clear();
                    for (int i = 0; i < cellCountY; i++)
                        cbCellIndexJ.Items.Add(i);
                    if (cbCellIndexJ.Items.Count > 0)
                        cbCellIndexJ.SelectedIndex = 0;

                }
            }
        }

        private void cbCellCountX_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void cbCellCountY_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateNeighbours()
        {
            int maxNeighbourCells = 0;
            int neighbourRing;
            if (Int32.TryParse(cbNeighbourRing.Text, out neighbourRing))
            {
                if (neighbourRing > 0)
                    maxNeighbourCells = 2 * neighbourRing * 4;
            }

            txtMaxNeibhourCells.Text = maxNeighbourCells.ToString();
        }

        private void cbNeighbourRing_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNeighbours();

            UpdateCellIndexNeighbours();
        }

        private void UpdateCellIndexNeighbours()
        {
            int neighbourRing;
            if (Int32.TryParse(cbNeighbourRing.Text, out neighbourRing))
            {
                int cellX;
                int cellY;
                if (Int32.TryParse(cbCellIndexI.Text, out cellX) &&
                    Int32.TryParse(cbCellIndexJ.Text, out cellY))
                {
                    if (cellX >= 0 && cellY >= 0)
                    {
                        List<CellPoint> neighbourCellPoints = GetNeighboursIndicesList(cellX, cellY, neighbourRing);

                        txtNeighbourCells.Text = neighbourCellPoints.Count.ToString();

                    }
                }
            }
        }

        private void cbCellIndexI_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCellIndexNeighbours();
        }

        private void cbCellIndexJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCellIndexNeighbours();
        }
    }

    class CellPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
