﻿namespace Practica1
{
    partial class input_window
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewPastProcesses = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxInProgress = new System.Windows.Forms.GroupBox();
            this._contLotesOutput = new System.Windows.Forms.Label();
            this._contLoteslbl = new System.Windows.Forms.Label();
            this.labelProgrammerName = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.processTimertxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timeTxt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxInProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 450);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.listViewPastProcesses);
            this.tabPage2.Controls.Add(this.groupBoxInProgress);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.timeTxt);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Procesos";
            this.tabPage2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tabPage2_PreviewKeyDown);
            // 
            // listViewPastProcesses
            // 
            this.listViewPastProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPastProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.operacion,
            this.tiempo});
            this.listViewPastProcesses.HideSelection = false;
            this.listViewPastProcesses.Location = new System.Drawing.Point(451, 6);
            this.listViewPastProcesses.Name = "listViewPastProcesses";
            this.listViewPastProcesses.Size = new System.Drawing.Size(284, 368);
            this.listViewPastProcesses.TabIndex = 11;
            this.listViewPastProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewPastProcesses.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // operacion
            // 
            this.operacion.Text = "Operacion";
            // 
            // tiempo
            // 
            this.tiempo.Text = "Tiempo";
            // 
            // groupBoxInProgress
            // 
            this.groupBoxInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInProgress.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInProgress.Controls.Add(this._contLotesOutput);
            this.groupBoxInProgress.Controls.Add(this._contLoteslbl);
            this.groupBoxInProgress.Controls.Add(this.labelProgrammerName);
            this.groupBoxInProgress.Controls.Add(this.labelOperation);
            this.groupBoxInProgress.Controls.Add(this.labelId);
            this.groupBoxInProgress.Controls.Add(this.label4);
            this.groupBoxInProgress.Controls.Add(this.label2);
            this.groupBoxInProgress.Controls.Add(this.label3);
            this.groupBoxInProgress.Controls.Add(this.processTimertxt);
            this.groupBoxInProgress.Location = new System.Drawing.Point(8, 193);
            this.groupBoxInProgress.Name = "groupBoxInProgress";
            this.groupBoxInProgress.Size = new System.Drawing.Size(365, 181);
            this.groupBoxInProgress.TabIndex = 10;
            this.groupBoxInProgress.TabStop = false;
            this.groupBoxInProgress.Text = "Proceso en ejecución";
            // 
            // _contLotesOutput
            // 
            this._contLotesOutput.AutoSize = true;
            this._contLotesOutput.Location = new System.Drawing.Point(160, 110);
            this._contLotesOutput.Name = "_contLotesOutput";
            this._contLotesOutput.Size = new System.Drawing.Size(14, 16);
            this._contLotesOutput.TabIndex = 15;
            this._contLotesOutput.Text = "0";
            // 
            // _contLoteslbl
            // 
            this._contLoteslbl.AutoSize = true;
            this._contLoteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._contLoteslbl.Location = new System.Drawing.Point(17, 111);
            this._contLoteslbl.Name = "_contLoteslbl";
            this._contLoteslbl.Size = new System.Drawing.Size(117, 16);
            this._contLoteslbl.TabIndex = 14;
            this._contLoteslbl.Text = "Lotes restantes:";
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.AutoSize = true;
            this.labelProgrammerName.Location = new System.Drawing.Point(147, 85);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(0, 16);
            this.labelProgrammerName.TabIndex = 13;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(147, 86);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 16);
            this.labelOperation.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(147, 57);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 16);
            this.labelId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operacion: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiempo restante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Programa:";
            // 
            // processTimertxt
            // 
            this.processTimertxt.AutoSize = true;
            this.processTimertxt.Location = new System.Drawing.Point(160, 28);
            this.processTimertxt.Name = "processTimertxt";
            this.processTimertxt.Size = new System.Drawing.Size(14, 16);
            this.processTimertxt.TabIndex = 6;
            this.processTimertxt.Text = "0";
            this.processTimertxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo Total:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(248, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Empezar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.startBtn);
            // 
            // timeTxt
            // 
            this.timeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTxt.Location = new System.Drawing.Point(125, 383);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(55, 16);
            this.timeTxt.TabIndex = 4;
            this.timeTxt.Text = "00:00:00";
            this.timeTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeTxt.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(132, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(23, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(80, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(23, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(28, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(23, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // input_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "input_window";
            this.Text = "Practica2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.input_window_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_window_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxInProgress.ResumeLayout(false);
            this.groupBoxInProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;

        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label processTimertxt;
        private System.Windows.Forms.GroupBox groupBoxInProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgrammerName;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListView listViewPastProcesses;
        private System.Windows.Forms.Label _contLoteslbl;
        private System.Windows.Forms.Label _contLotesOutput;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader operacion;
        private System.Windows.Forms.ColumnHeader tiempo;
    }
}

