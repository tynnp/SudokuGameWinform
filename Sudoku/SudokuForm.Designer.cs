
using System.Media;

namespace Sudoku
{
    partial class SudokuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuForm));
            btnGenerate = new System.Windows.Forms.Button();
            btnSolve = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            lblTimer = new System.Windows.Forms.Label();
            timer = new System.Windows.Forms.Timer(components);
            cmbBoxMode = new System.Windows.Forms.ComboBox();
            cmbBoxGrid = new System.Windows.Forms.ComboBox();
            lblMode = new System.Windows.Forms.Label();
            lblGrid = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            gridView = new System.Windows.Forms.DataGridView();
            btnValidate = new System.Windows.Forms.Button();
            messageTimer = new System.Windows.Forms.Timer(components);
            btnHoTro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            SoundPlayer player_background = new SoundPlayer("Audios/sound_backgroundmusic.wav");
            player_background.Play();
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGenerate.BackColor = System.Drawing.Color.DarkSlateBlue;
            btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerate.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGenerate.ForeColor = System.Drawing.Color.White;
            btnGenerate.Location = new System.Drawing.Point(709, 255);
            btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(86, 31);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Khởi tạo bảng";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // btnSolve
            // 
            btnSolve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSolve.BackColor = System.Drawing.Color.Green;
            btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSolve.FlatAppearance.BorderSize = 0;
            btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSolve.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSolve.ForeColor = System.Drawing.Color.White;
            btnSolve.Location = new System.Drawing.Point(709, 369);
            btnSolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new System.Drawing.Size(86, 31);
            btnSolve.TabIndex = 2;
            btnSolve.Text = "Giải";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += BtnSolve_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnReset.BackColor = System.Drawing.Color.Silver;
            btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReset.ForeColor = System.Drawing.Color.Black;
            btnReset.Location = new System.Drawing.Point(709, 428);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(86, 31);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTimer.AutoSize = true;
            lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTimer.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTimer.ForeColor = System.Drawing.Color.White;
            lblTimer.Location = new System.Drawing.Point(329, 8);
            lblTimer.Name = "lblTimer";
            lblTimer.Padding = new System.Windows.Forms.Padding(23, 20, 23, 20);
            lblTimer.Size = new System.Drawing.Size(212, 81);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            // 
            // cmbBoxMode
            // 
            cmbBoxMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxMode.Cursor = System.Windows.Forms.Cursors.Hand;
            cmbBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBoxMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbBoxMode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbBoxMode.FormattingEnabled = true;
            cmbBoxMode.Items.AddRange(new object[] { "Dễ", "Trung bình", "Khó" });
            cmbBoxMode.Location = new System.Drawing.Point(33, 64);
            cmbBoxMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbBoxMode.Name = "cmbBoxMode";
            cmbBoxMode.Size = new System.Drawing.Size(138, 27);
            cmbBoxMode.TabIndex = 4;
            cmbBoxMode.SelectedIndexChanged += CmbBoxMode_SelectedIndexChanged;
            // 
            // cmbBoxGrid
            // 
            cmbBoxGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            cmbBoxGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBoxGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbBoxGrid.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbBoxGrid.FormattingEnabled = true;
            cmbBoxGrid.Items.AddRange(new object[] { "4 X 4", "9 X 9" });
            cmbBoxGrid.Location = new System.Drawing.Point(33, 129);
            cmbBoxGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbBoxGrid.Name = "cmbBoxGrid";
            cmbBoxGrid.Size = new System.Drawing.Size(138, 27);
            cmbBoxGrid.TabIndex = 5;
            cmbBoxGrid.SelectedIndexChanged += CmbBoxGrid_SelectedIndexChanged;
            // 
            // lblMode
            // 
            lblMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMode.AutoSize = true;
            lblMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblMode.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMode.ForeColor = System.Drawing.Color.White;
            lblMode.Location = new System.Drawing.Point(33, 39);
            lblMode.Name = "lblMode";
            lblMode.Size = new System.Drawing.Size(62, 20);
            lblMode.TabIndex = 6;
            lblMode.Text = "Chế độ";
            // 
            // lblGrid
            // 
            lblGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblGrid.AutoSize = true;
            lblGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblGrid.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGrid.ForeColor = System.Drawing.Color.White;
            lblGrid.Location = new System.Drawing.Point(33, 104);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new System.Drawing.Size(40, 20);
            lblGrid.TabIndex = 7;
            lblGrid.Text = "Số ô";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblStatus.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(191, 95);
            lblStatus.MinimumSize = new System.Drawing.Size(493, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(493, 22);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Bắt đầu giải Sudoku";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridView
            // 
            gridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            gridView.BackgroundColor = System.Drawing.Color.Gray;
            gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.GridColor = System.Drawing.Color.White;
            gridView.Location = new System.Drawing.Point(213, 132);
            gridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridView.Name = "gridView";
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 25;
            gridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            gridView.Size = new System.Drawing.Size(443, 517);
            gridView.TabIndex = 6;
            // 
            // btnValidate
            // 
            btnValidate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnValidate.BackColor = System.Drawing.Color.SteelBlue;
            btnValidate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnValidate.FlatAppearance.BorderSize = 0;
            btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnValidate.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnValidate.ForeColor = System.Drawing.Color.White;
            btnValidate.Location = new System.Drawing.Point(709, 312);
            btnValidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new System.Drawing.Size(86, 31);
            btnValidate.TabIndex = 1;
            btnValidate.Text = "Kiểm tra";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += BtnValidate_Click;
            // 
            // messageTimer
            // 
            messageTimer.Enabled = true;
            messageTimer.Interval = 5000;
            messageTimer.Tick += MessageTimer_Tick;
            // 
            // btnHoTro
            // 
            btnHoTro.Location = new System.Drawing.Point(757, 8);
            btnHoTro.Name = "btnHoTro";
            btnHoTro.Size = new System.Drawing.Size(94, 29);
            btnHoTro.TabIndex = 9;
            btnHoTro.Text = "Hỗ trợ";
            btnHoTro.UseVisualStyleBackColor = true;
            btnHoTro.Click += button1_Click;
            // 
            // SudokuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(47, 47, 47);
            ClientSize = new System.Drawing.Size(863, 671);
            Controls.Add(btnHoTro);
            Controls.Add(btnValidate);
            Controls.Add(gridView);
            Controls.Add(lblStatus);
            Controls.Add(lblGrid);
            Controls.Add(lblMode);
            Controls.Add(cmbBoxGrid);
            Controls.Add(cmbBoxMode);
            Controls.Add(lblTimer);
            Controls.Add(btnReset);
            Controls.Add(btnSolve);
            Controls.Add(btnGenerate);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SudokuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sudoku";
            Load += SudokuForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmbBoxMode;
        private System.Windows.Forms.ComboBox cmbBoxGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Button btnHoTro;
    }
}

