
namespace Drone_Simulator_WinForm
{
    partial class Drone
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlSimulator = new System.Windows.Forms.Panel();
            this.grpInstruction = new System.Windows.Forms.GroupBox();
            this.txtXCoordinate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYCoordinate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlyTime = new System.Windows.Forms.TextBox();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lblMainXCoord = new System.Windows.Forms.Label();
            this.txtMainXCoord = new System.Windows.Forms.TextBox();
            this.lblMainYCoord = new System.Windows.Forms.Label();
            this.txtMainYCoord = new System.Windows.Forms.TextBox();
            this.pnlSimulator.SuspendLayout();
            this.grpInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(452, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start (S)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlSimulator
            // 
            this.pnlSimulator.Controls.Add(this.grpInstruction);
            this.pnlSimulator.Location = new System.Drawing.Point(13, 42);
            this.pnlSimulator.Name = "pnlSimulator";
            this.pnlSimulator.Size = new System.Drawing.Size(970, 634);
            this.pnlSimulator.TabIndex = 1;
            this.pnlSimulator.Visible = false;
            // 
            // grpInstruction
            // 
            this.grpInstruction.Controls.Add(this.btnShutdown);
            this.grpInstruction.Controls.Add(this.btnReset);
            this.grpInstruction.Controls.Add(this.btnFly);
            this.grpInstruction.Controls.Add(this.label3);
            this.grpInstruction.Controls.Add(this.txtFlyTime);
            this.grpInstruction.Controls.Add(this.label2);
            this.grpInstruction.Controls.Add(this.txtYCoordinate);
            this.grpInstruction.Controls.Add(this.label1);
            this.grpInstruction.Controls.Add(this.txtXCoordinate);
            this.grpInstruction.Location = new System.Drawing.Point(4, 3);
            this.grpInstruction.Name = "grpInstruction";
            this.grpInstruction.Size = new System.Drawing.Size(963, 184);
            this.grpInstruction.TabIndex = 0;
            this.grpInstruction.TabStop = false;
            this.grpInstruction.Text = "Instruction";
            // 
            // txtXCoordinate
            // 
            this.txtXCoordinate.Location = new System.Drawing.Point(110, 30);
            this.txtXCoordinate.Name = "txtXCoordinate";
            this.txtXCoordinate.Size = new System.Drawing.Size(85, 22);
            this.txtXCoordinate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x cordinate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "y cordinate :";
            // 
            // txtYCoordinate
            // 
            this.txtYCoordinate.Location = new System.Drawing.Point(319, 30);
            this.txtYCoordinate.Name = "txtYCoordinate";
            this.txtYCoordinate.Size = new System.Drawing.Size(85, 22);
            this.txtYCoordinate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fly Time :";
            // 
            // txtFlyTime
            // 
            this.txtFlyTime.Location = new System.Drawing.Point(522, 30);
            this.txtFlyTime.Name = "txtFlyTime";
            this.txtFlyTime.Size = new System.Drawing.Size(85, 22);
            this.txtFlyTime.TabIndex = 4;
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(637, 22);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(85, 38);
            this.btnFly.TabIndex = 6;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(743, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 38);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(849, 22);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(85, 38);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "Shut Down";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMainXCoord
            // 
            this.lblMainXCoord.AutoSize = true;
            this.lblMainXCoord.Location = new System.Drawing.Point(17, 16);
            this.lblMainXCoord.Name = "lblMainXCoord";
            this.lblMainXCoord.Size = new System.Drawing.Size(82, 17);
            this.lblMainXCoord.TabIndex = 2;
            this.lblMainXCoord.Text = "X Boundary";
            // 
            // txtMainXCoord
            // 
            this.txtMainXCoord.Location = new System.Drawing.Point(105, 13);
            this.txtMainXCoord.Name = "txtMainXCoord";
            this.txtMainXCoord.Size = new System.Drawing.Size(100, 22);
            this.txtMainXCoord.TabIndex = 3;
            // 
            // lblMainYCoord
            // 
            this.lblMainYCoord.AutoSize = true;
            this.lblMainYCoord.Location = new System.Drawing.Point(222, 15);
            this.lblMainYCoord.Name = "lblMainYCoord";
            this.lblMainYCoord.Size = new System.Drawing.Size(82, 17);
            this.lblMainYCoord.TabIndex = 4;
            this.lblMainYCoord.Text = "Y Boundary";
            // 
            // txtMainYCoord
            // 
            this.txtMainYCoord.Location = new System.Drawing.Point(310, 13);
            this.txtMainYCoord.Name = "txtMainYCoord";
            this.txtMainYCoord.Size = new System.Drawing.Size(100, 22);
            this.txtMainYCoord.TabIndex = 5;
            // 
            // Drone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.txtMainYCoord);
            this.Controls.Add(this.lblMainYCoord);
            this.Controls.Add(this.txtMainXCoord);
            this.Controls.Add(this.lblMainXCoord);
            this.Controls.Add(this.pnlSimulator);
            this.Controls.Add(this.btnStart);
            this.Name = "Drone";
            this.Text = "Drone Simulator";
            this.pnlSimulator.ResumeLayout(false);
            this.grpInstruction.ResumeLayout(false);
            this.grpInstruction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlSimulator;
        private System.Windows.Forms.GroupBox grpInstruction;
        private System.Windows.Forms.TextBox txtXCoordinate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlyTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYCoordinate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMainXCoord;
        private System.Windows.Forms.TextBox txtMainXCoord;
        private System.Windows.Forms.Label lblMainYCoord;
        private System.Windows.Forms.TextBox txtMainYCoord;
    }
}

