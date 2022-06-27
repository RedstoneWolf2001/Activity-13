namespace Activity_13
{
    partial class Form1
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
            this.TopLeft = new System.Windows.Forms.Button();
            this.TopCenter = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            this.MiddleLeft = new System.Windows.Forms.Button();
            this.MiddleCenter = new System.Windows.Forms.Button();
            this.MiddleRight = new System.Windows.Forms.Button();
            this.BottomLeft = new System.Windows.Forms.Button();
            this.BottomCenter = new System.Windows.Forms.Button();
            this.BottomRight = new System.Windows.Forms.Button();
            this.ResultsTB = new System.Windows.Forms.TextBox();
            this.NewGameBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLeft
            // 
            this.TopLeft.Location = new System.Drawing.Point(31, 12);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(50, 50);
            this.TopLeft.TabIndex = 0;
            this.TopLeft.UseVisualStyleBackColor = true;
            // 
            // TopCenter
            // 
            this.TopCenter.Location = new System.Drawing.Point(87, 12);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.Size = new System.Drawing.Size(50, 50);
            this.TopCenter.TabIndex = 1;
            this.TopCenter.UseVisualStyleBackColor = true;
            // 
            // TopRight
            // 
            this.TopRight.Location = new System.Drawing.Point(143, 12);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(50, 50);
            this.TopRight.TabIndex = 2;
            this.TopRight.UseVisualStyleBackColor = true;
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Location = new System.Drawing.Point(31, 68);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(50, 50);
            this.MiddleLeft.TabIndex = 3;
            this.MiddleLeft.UseVisualStyleBackColor = true;
            // 
            // MiddleCenter
            // 
            this.MiddleCenter.Location = new System.Drawing.Point(87, 68);
            this.MiddleCenter.Name = "MiddleCenter";
            this.MiddleCenter.Size = new System.Drawing.Size(50, 50);
            this.MiddleCenter.TabIndex = 4;
            this.MiddleCenter.UseVisualStyleBackColor = true;
            // 
            // MiddleRight
            // 
            this.MiddleRight.Location = new System.Drawing.Point(143, 68);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(50, 50);
            this.MiddleRight.TabIndex = 5;
            this.MiddleRight.UseVisualStyleBackColor = true;
            // 
            // BottomLeft
            // 
            this.BottomLeft.Location = new System.Drawing.Point(31, 124);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(50, 50);
            this.BottomLeft.TabIndex = 6;
            this.BottomLeft.UseVisualStyleBackColor = true;
            // 
            // BottomCenter
            // 
            this.BottomCenter.Location = new System.Drawing.Point(87, 124);
            this.BottomCenter.Name = "BottomCenter";
            this.BottomCenter.Size = new System.Drawing.Size(50, 50);
            this.BottomCenter.TabIndex = 7;
            this.BottomCenter.UseVisualStyleBackColor = true;
            // 
            // BottomRight
            // 
            this.BottomRight.Location = new System.Drawing.Point(143, 124);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(50, 50);
            this.BottomRight.TabIndex = 8;
            this.BottomRight.UseVisualStyleBackColor = true;
            // 
            // ResultsTB
            // 
            this.ResultsTB.Location = new System.Drawing.Point(31, 181);
            this.ResultsTB.Name = "ResultsTB";
            this.ResultsTB.ReadOnly = true;
            this.ResultsTB.Size = new System.Drawing.Size(162, 20);
            this.ResultsTB.TabIndex = 9;
            this.ResultsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewGameBTN
            // 
            this.NewGameBTN.Location = new System.Drawing.Point(31, 208);
            this.NewGameBTN.Name = "NewGameBTN";
            this.NewGameBTN.Size = new System.Drawing.Size(75, 23);
            this.NewGameBTN.TabIndex = 10;
            this.NewGameBTN.Text = "New Game!";
            this.NewGameBTN.UseVisualStyleBackColor = true;
            this.NewGameBTN.Click += new System.EventHandler(this.NewGameBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(117, 208);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseBTN.TabIndex = 11;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 248);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.NewGameBTN);
            this.Controls.Add(this.ResultsTB);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.BottomCenter);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.MiddleCenter);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.TopLeft);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button TopCenter;
        private System.Windows.Forms.Button TopRight;
        private System.Windows.Forms.Button MiddleLeft;
        private System.Windows.Forms.Button MiddleCenter;
        private System.Windows.Forms.Button MiddleRight;
        private System.Windows.Forms.Button BottomLeft;
        private System.Windows.Forms.Button BottomCenter;
        private System.Windows.Forms.Button BottomRight;
        private System.Windows.Forms.TextBox ResultsTB;
        private System.Windows.Forms.Button NewGameBTN;
        private System.Windows.Forms.Button CloseBTN;
    }
}

