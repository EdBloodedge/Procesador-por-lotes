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
            this.blockedTimer3 = new System.Windows.Forms.Label();
            this.blockedTimer2 = new System.Windows.Forms.Label();
            this.blockedTimer1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.labelLlegada = new System.Windows.Forms.Label();
            this.labelFinalizacion = new System.Windows.Forms.Label();
            this.labelLlegadaTxt = new System.Windows.Forms.Label();
            this.labelFinalizacionTxt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxInProgress.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1375, 562);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.groupBoxTimer);
            this.tabPage2.Controls.Add(this.blockedTimer3);
            this.tabPage2.Controls.Add(this.blockedTimer2);
            this.tabPage2.Controls.Add(this.blockedTimer1);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.listViewPastProcesses);
            this.tabPage2.Controls.Add(this.groupBoxInProgress);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.timeTxt);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1367, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Procesos";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tabPage2_PreviewKeyDown);
            // 
            // blockedTimer3
            // 
            this.blockedTimer3.AutoSize = true;
            this.blockedTimer3.Location = new System.Drawing.Point(243, 211);
            this.blockedTimer3.Name = "blockedTimer3";
            this.blockedTimer3.Size = new System.Drawing.Size(0, 20);
            this.blockedTimer3.TabIndex = 17;
            // 
            // blockedTimer2
            // 
            this.blockedTimer2.AutoSize = true;
            this.blockedTimer2.Location = new System.Drawing.Point(141, 211);
            this.blockedTimer2.Name = "blockedTimer2";
            this.blockedTimer2.Size = new System.Drawing.Size(0, 20);
            this.blockedTimer2.TabIndex = 16;
            // 
            // blockedTimer1
            // 
            this.blockedTimer1.AutoSize = true;
            this.blockedTimer1.Location = new System.Drawing.Point(28, 211);
            this.blockedTimer1.Name = "blockedTimer1";
            this.blockedTimer1.Size = new System.Drawing.Size(0, 20);
            this.blockedTimer1.TabIndex = 15;
            this.blockedTimer1.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox6.Location = new System.Drawing.Point(327, 82);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(108, 30);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bloqueado";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox5.Location = new System.Drawing.Point(327, 45);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(108, 30);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ejecucion";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox4.Location = new System.Drawing.Point(327, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(108, 30);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listo";
            // 
            // listViewPastProcesses
            // 
            this.listViewPastProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPastProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.operacion,
            this.tiempo});
            this.listViewPastProcesses.HideSelection = false;
            this.listViewPastProcesses.Location = new System.Drawing.Point(960, 23);
            this.listViewPastProcesses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewPastProcesses.Name = "listViewPastProcesses";
            this.listViewPastProcesses.Size = new System.Drawing.Size(383, 459);
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
            this.groupBoxInProgress.Location = new System.Drawing.Point(9, 241);
            this.groupBoxInProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInProgress.Name = "groupBoxInProgress";
            this.groupBoxInProgress.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInProgress.Size = new System.Drawing.Size(411, 226);
            this.groupBoxInProgress.TabIndex = 10;
            this.groupBoxInProgress.TabStop = false;
            this.groupBoxInProgress.Text = "Proceso en ejecución";
            // 
            // _contLotesOutput
            // 
            this._contLotesOutput.AutoSize = true;
            this._contLotesOutput.Location = new System.Drawing.Point(180, 138);
            this._contLotesOutput.Name = "_contLotesOutput";
            this._contLotesOutput.Size = new System.Drawing.Size(18, 20);
            this._contLotesOutput.TabIndex = 15;
            this._contLotesOutput.Text = "0";
            // 
            // _contLoteslbl
            // 
            this._contLoteslbl.AutoSize = true;
            this._contLoteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._contLoteslbl.Location = new System.Drawing.Point(19, 139);
            this._contLoteslbl.Name = "_contLoteslbl";
            this._contLoteslbl.Size = new System.Drawing.Size(140, 20);
            this._contLoteslbl.TabIndex = 14;
            this._contLoteslbl.Text = "Lotes restantes:";
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.AutoSize = true;
            this.labelProgrammerName.Location = new System.Drawing.Point(165, 106);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(0, 20);
            this.labelProgrammerName.TabIndex = 13;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(165, 108);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 20);
            this.labelOperation.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(165, 71);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 20);
            this.labelId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operacion: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiempo restante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Programa:";
            // 
            // processTimertxt
            // 
            this.processTimertxt.AutoSize = true;
            this.processTimertxt.Location = new System.Drawing.Point(180, 35);
            this.processTimertxt.Name = "processTimertxt";
            this.processTimertxt.Size = new System.Drawing.Size(18, 20);
            this.processTimertxt.TabIndex = 6;
            this.processTimertxt.Text = "0";
            this.processTimertxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo Total:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(279, 475);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 29);
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
            this.timeTxt.Location = new System.Drawing.Point(141, 479);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(71, 20);
            this.timeTxt.TabIndex = 4;
            this.timeTxt.Text = "00:00:00";
            this.timeTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeTxt.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(246, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(52, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(142, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(48, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(32, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(51, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.labelFinalizacionTxt);
            this.groupBoxTimer.Controls.Add(this.labelLlegadaTxt);
            this.groupBoxTimer.Controls.Add(this.labelFinalizacion);
            this.groupBoxTimer.Controls.Add(this.labelLlegada);
            this.groupBoxTimer.Location = new System.Drawing.Point(442, 241);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(428, 159);
            this.groupBoxTimer.TabIndex = 18;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Tiempo";
            // 
            // labelLlegada
            // 
            this.labelLlegada.AutoSize = true;
            this.labelLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLlegada.Location = new System.Drawing.Point(16, 35);
            this.labelLlegada.Name = "labelLlegada";
            this.labelLlegada.Size = new System.Drawing.Size(83, 20);
            this.labelLlegada.TabIndex = 0;
            this.labelLlegada.Text = "Llegada: ";
            this.labelLlegada.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // labelFinalizacion
            // 
            this.labelFinalizacion.AutoSize = true;
            this.labelFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalizacion.Location = new System.Drawing.Point(20, 86);
            this.labelFinalizacion.Name = "labelFinalizacion";
            this.labelFinalizacion.Size = new System.Drawing.Size(104, 20);
            this.labelFinalizacion.TabIndex = 1;
            this.labelFinalizacion.Text = "Finalizacion";
            this.labelFinalizacion.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // labelLlegadaTxt
            // 
            this.labelLlegadaTxt.AutoSize = true;
            this.labelLlegadaTxt.Location = new System.Drawing.Point(141, 35);
            this.labelLlegadaTxt.Name = "labelLlegadaTxt";
            this.labelLlegadaTxt.Size = new System.Drawing.Size(18, 20);
            this.labelLlegadaTxt.TabIndex = 2;
            this.labelLlegadaTxt.Text = "0";
            // 
            // labelFinalizacionTxt
            // 
            this.labelFinalizacionTxt.AutoSize = true;
            this.labelFinalizacionTxt.Location = new System.Drawing.Point(145, 85);
            this.labelFinalizacionTxt.Name = "labelFinalizacionTxt";
            this.labelFinalizacionTxt.Size = new System.Drawing.Size(18, 20);
            this.labelFinalizacionTxt.TabIndex = 3;
            this.labelFinalizacionTxt.Text = "0";
            // 
            // input_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1374, 562);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "input_window";
            this.Text = "Practica 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.input_window_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_window_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxInProgress.ResumeLayout(false);
            this.groupBoxInProgress.PerformLayout();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label blockedTimer3;
        private System.Windows.Forms.Label blockedTimer2;
        private System.Windows.Forms.Label blockedTimer1;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Label labelFinalizacionTxt;
        private System.Windows.Forms.Label labelLlegadaTxt;
        private System.Windows.Forms.Label labelFinalizacion;
        private System.Windows.Forms.Label labelLlegada;
    }
}

