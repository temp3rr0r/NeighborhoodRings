namespace NeighborhoodRings1
{
    partial class FormNeighborhoodIndexFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cbCellIndexI = new System.Windows.Forms.ComboBox();
            this.cbCellIndexJ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCellularAutomataModel = new System.Windows.Forms.GroupBox();
            this.cbCellCountX = new System.Windows.Forms.ComboBox();
            this.cbCellType = new System.Windows.Forms.ComboBox();
            this.txtCellCount = new System.Windows.Forms.TextBox();
            this.lblCellCountX = new System.Windows.Forms.Label();
            this.cbCellCountY = new System.Windows.Forms.ComboBox();
            this.lblCellCount = new System.Windows.Forms.Label();
            this.lblCellType = new System.Windows.Forms.Label();
            this.lblCellCountY = new System.Windows.Forms.Label();
            this.cbNeighborhoodSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNeighborhoodType = new System.Windows.Forms.ComboBox();
            this.lblNeighborhoodType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNeighbourCells = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxNeibhourCells = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNeighbourRing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpCellularAutomataModel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find Neighbours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCellIndexI
            // 
            this.cbCellIndexI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCellIndexI.FormattingEnabled = true;
            this.cbCellIndexI.Location = new System.Drawing.Point(81, 19);
            this.cbCellIndexI.Name = "cbCellIndexI";
            this.cbCellIndexI.Size = new System.Drawing.Size(88, 21);
            this.cbCellIndexI.TabIndex = 4;
            this.cbCellIndexI.SelectedIndexChanged += new System.EventHandler(this.cbCellIndexI_SelectedIndexChanged);
            // 
            // cbCellIndexJ
            // 
            this.cbCellIndexJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCellIndexJ.FormattingEnabled = true;
            this.cbCellIndexJ.Location = new System.Drawing.Point(82, 46);
            this.cbCellIndexJ.Name = "cbCellIndexJ";
            this.cbCellIndexJ.Size = new System.Drawing.Size(88, 21);
            this.cbCellIndexJ.TabIndex = 5;
            this.cbCellIndexJ.SelectedIndexChanged += new System.EventHandler(this.cbCellIndexJ_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Index i:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Index j:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCellIndexI);
            this.groupBox1.Controls.Add(this.cbCellIndexJ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell:";
            // 
            // grpCellularAutomataModel
            // 
            this.grpCellularAutomataModel.Controls.Add(this.cbCellCountX);
            this.grpCellularAutomataModel.Controls.Add(this.cbCellType);
            this.grpCellularAutomataModel.Controls.Add(this.txtCellCount);
            this.grpCellularAutomataModel.Controls.Add(this.lblCellCountX);
            this.grpCellularAutomataModel.Controls.Add(this.cbCellCountY);
            this.grpCellularAutomataModel.Controls.Add(this.lblCellCount);
            this.grpCellularAutomataModel.Controls.Add(this.lblCellType);
            this.grpCellularAutomataModel.Controls.Add(this.lblCellCountY);
            this.grpCellularAutomataModel.Location = new System.Drawing.Point(12, 12);
            this.grpCellularAutomataModel.Name = "grpCellularAutomataModel";
            this.grpCellularAutomataModel.Size = new System.Drawing.Size(364, 103);
            this.grpCellularAutomataModel.TabIndex = 16;
            this.grpCellularAutomataModel.TabStop = false;
            this.grpCellularAutomataModel.Text = "Cellular Automata Model:";
            // 
            // cbCellCountX
            // 
            this.cbCellCountX.FormattingEnabled = true;
            this.cbCellCountX.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "75",
            "100"});
            this.cbCellCountX.Location = new System.Drawing.Point(81, 19);
            this.cbCellCountX.Name = "cbCellCountX";
            this.cbCellCountX.Size = new System.Drawing.Size(89, 21);
            this.cbCellCountX.TabIndex = 5;
            this.cbCellCountX.SelectedIndexChanged += new System.EventHandler(this.cbCellCountX_SelectedIndexChanged);
            // 
            // cbCellType
            // 
            this.cbCellType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCellType.Enabled = false;
            this.cbCellType.FormattingEnabled = true;
            this.cbCellType.Items.AddRange(new object[] {
            "Square",
            "Hexagon"});
            this.cbCellType.Location = new System.Drawing.Point(81, 73);
            this.cbCellType.Name = "cbCellType";
            this.cbCellType.Size = new System.Drawing.Size(89, 21);
            this.cbCellType.TabIndex = 11;
            // 
            // txtCellCount
            // 
            this.txtCellCount.Enabled = false;
            this.txtCellCount.Location = new System.Drawing.Point(240, 19);
            this.txtCellCount.Name = "txtCellCount";
            this.txtCellCount.Size = new System.Drawing.Size(89, 20);
            this.txtCellCount.TabIndex = 19;
            // 
            // lblCellCountX
            // 
            this.lblCellCountX.AutoSize = true;
            this.lblCellCountX.Location = new System.Drawing.Point(7, 22);
            this.lblCellCountX.Name = "lblCellCountX";
            this.lblCellCountX.Size = new System.Drawing.Size(68, 13);
            this.lblCellCountX.TabIndex = 6;
            this.lblCellCountX.Text = "Cell Count X:";
            // 
            // cbCellCountY
            // 
            this.cbCellCountY.FormattingEnabled = true;
            this.cbCellCountY.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "75",
            "100"});
            this.cbCellCountY.Location = new System.Drawing.Point(81, 46);
            this.cbCellCountY.Name = "cbCellCountY";
            this.cbCellCountY.Size = new System.Drawing.Size(89, 21);
            this.cbCellCountY.TabIndex = 10;
            this.cbCellCountY.SelectedIndexChanged += new System.EventHandler(this.cbCellCountY_SelectedIndexChanged);
            // 
            // lblCellCount
            // 
            this.lblCellCount.AutoSize = true;
            this.lblCellCount.Location = new System.Drawing.Point(176, 22);
            this.lblCellCount.Name = "lblCellCount";
            this.lblCellCount.Size = new System.Drawing.Size(58, 13);
            this.lblCellCount.TabIndex = 9;
            this.lblCellCount.Text = "Cell Count:";
            // 
            // lblCellType
            // 
            this.lblCellType.AutoSize = true;
            this.lblCellType.Location = new System.Drawing.Point(21, 76);
            this.lblCellType.Name = "lblCellType";
            this.lblCellType.Size = new System.Drawing.Size(54, 13);
            this.lblCellType.TabIndex = 8;
            this.lblCellType.Text = "Cell Type:";
            // 
            // lblCellCountY
            // 
            this.lblCellCountY.AutoSize = true;
            this.lblCellCountY.Location = new System.Drawing.Point(7, 49);
            this.lblCellCountY.Name = "lblCellCountY";
            this.lblCellCountY.Size = new System.Drawing.Size(68, 13);
            this.lblCellCountY.TabIndex = 7;
            this.lblCellCountY.Text = "Cell Count Y:";
            // 
            // cbNeighborhoodSize
            // 
            this.cbNeighborhoodSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNeighborhoodSize.Enabled = false;
            this.cbNeighborhoodSize.FormattingEnabled = true;
            this.cbNeighborhoodSize.Items.AddRange(new object[] {
            "8",
            "25"});
            this.cbNeighborhoodSize.Location = new System.Drawing.Point(81, 99);
            this.cbNeighborhoodSize.Name = "cbNeighborhoodSize";
            this.cbNeighborhoodSize.Size = new System.Drawing.Size(89, 21);
            this.cbNeighborhoodSize.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Num Neighbr:";
            // 
            // cbNeighborhoodType
            // 
            this.cbNeighborhoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNeighborhoodType.Enabled = false;
            this.cbNeighborhoodType.FormattingEnabled = true;
            this.cbNeighborhoodType.Items.AddRange(new object[] {
            "Square",
            "Hexagon"});
            this.cbNeighborhoodType.Location = new System.Drawing.Point(80, 72);
            this.cbNeighborhoodType.Name = "cbNeighborhoodType";
            this.cbNeighborhoodType.Size = new System.Drawing.Size(89, 21);
            this.cbNeighborhoodType.TabIndex = 22;
            // 
            // lblNeighborhoodType
            // 
            this.lblNeighborhoodType.AutoSize = true;
            this.lblNeighborhoodType.Location = new System.Drawing.Point(11, 75);
            this.lblNeighborhoodType.Name = "lblNeighborhoodType";
            this.lblNeighborhoodType.Size = new System.Drawing.Size(64, 13);
            this.lblNeighborhoodType.TabIndex = 20;
            this.lblNeighborhoodType.Text = "Neighbours:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNeighbourCells);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaxNeibhourCells);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbNeighbourRing);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbNeighborhoodSize);
            this.groupBox2.Controls.Add(this.lblNeighborhoodType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbNeighborhoodType);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbours:";
            // 
            // txtNeighbourCells
            // 
            this.txtNeighbourCells.Enabled = false;
            this.txtNeighbourCells.Location = new System.Drawing.Point(240, 46);
            this.txtNeighbourCells.Name = "txtNeighbourCells";
            this.txtNeighbourCells.Size = new System.Drawing.Size(89, 20);
            this.txtNeighbourCells.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cells:";
            // 
            // txtMaxNeibhourCells
            // 
            this.txtMaxNeibhourCells.Enabled = false;
            this.txtMaxNeibhourCells.Location = new System.Drawing.Point(240, 20);
            this.txtMaxNeibhourCells.Name = "txtMaxNeibhourCells";
            this.txtMaxNeibhourCells.Size = new System.Drawing.Size(89, 20);
            this.txtMaxNeibhourCells.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Max Cells:";
            // 
            // cbNeighbourRing
            // 
            this.cbNeighbourRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNeighbourRing.FormattingEnabled = true;
            this.cbNeighbourRing.Location = new System.Drawing.Point(81, 19);
            this.cbNeighbourRing.Name = "cbNeighbourRing";
            this.cbNeighbourRing.Size = new System.Drawing.Size(88, 21);
            this.cbNeighbourRing.TabIndex = 4;
            this.cbNeighbourRing.SelectedIndexChanged += new System.EventHandler(this.cbNeighbourRing_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ring:";
            // 
            // FormNeighborhoodIndexFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCellularAutomataModel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormNeighborhoodIndexFinder";
            this.Text = "Moore Neighborhood Ring Index finder";
            this.Load += new System.EventHandler(this.FormNeighbourIndexFinder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCellularAutomataModel.ResumeLayout(false);
            this.grpCellularAutomataModel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCellIndexI;
        private System.Windows.Forms.ComboBox cbCellIndexJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCellularAutomataModel;
        private System.Windows.Forms.ComboBox cbNeighborhoodSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNeighborhoodType;
        private System.Windows.Forms.Label lblNeighborhoodType;
        private System.Windows.Forms.TextBox txtCellCount;
        private System.Windows.Forms.Label lblCellCount;
        private System.Windows.Forms.ComboBox cbCellCountX;
        private System.Windows.Forms.ComboBox cbCellType;
        private System.Windows.Forms.Label lblCellCountX;
        private System.Windows.Forms.ComboBox cbCellCountY;
        private System.Windows.Forms.Label lblCellType;
        private System.Windows.Forms.Label lblCellCountY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNeighbourRing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxNeibhourCells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNeighbourCells;
        private System.Windows.Forms.Label label3;
    }
}

