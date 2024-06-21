
namespace WindowsFormsApp1
{
    partial class WatchFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchFileForm));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.richtxtFileUpdates = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedFilePath = new System.Windows.Forms.Label();
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.txtSetTimerInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelectFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFile.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(241, 66);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Choose Target File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // richtxtFileUpdates
            // 
            this.richtxtFileUpdates.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richtxtFileUpdates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richtxtFileUpdates.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtFileUpdates.Location = new System.Drawing.Point(0, 157);
            this.richtxtFileUpdates.Name = "richtxtFileUpdates";
            this.richtxtFileUpdates.ReadOnly = true;
            this.richtxtFileUpdates.Size = new System.Drawing.Size(974, 339);
            this.richtxtFileUpdates.TabIndex = 1;
            this.richtxtFileUpdates.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected File  : ";
            // 
            // lblSelectedFilePath
            // 
            this.lblSelectedFilePath.AutoSize = true;
            this.lblSelectedFilePath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFilePath.Location = new System.Drawing.Point(116, 93);
            this.lblSelectedFilePath.Name = "lblSelectedFilePath";
            this.lblSelectedFilePath.Size = new System.Drawing.Size(0, 15);
            this.lblSelectedFilePath.TabIndex = 3;
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.AutoSize = true;
            this.lblTimerDisplay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerDisplay.Location = new System.Drawing.Point(499, 31);
            this.lblTimerDisplay.Name = "lblTimerDisplay";
            this.lblTimerDisplay.Size = new System.Drawing.Size(174, 25);
            this.lblTimerDisplay.TabIndex = 4;
            this.lblTimerDisplay.Text = "Next File check in :";
            // 
            // txtSetTimerInterval
            // 
            this.txtSetTimerInterval.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetTimerInterval.Location = new System.Drawing.Point(299, 50);
            this.txtSetTimerInterval.Name = "txtSetTimerInterval";
            this.txtSetTimerInterval.Size = new System.Drawing.Size(148, 21);
            this.txtSetTimerInterval.TabIndex = 5;
            this.txtSetTimerInterval.Text = "15";
            this.txtSetTimerInterval.TextChanged += new System.EventHandler(this.txtSetTimerInterval_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Interval Time :  (in secs)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "The selected file has the following updates : ";
            // 
            // WatchFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSetTimerInterval);
            this.Controls.Add(this.lblTimerDisplay);
            this.Controls.Add(this.lblSelectedFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtFileUpdates);
            this.Controls.Add(this.btnSelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WatchFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring File Changes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RichTextBox richtxtFileUpdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedFilePath;
        private System.Windows.Forms.Label lblTimerDisplay;
        private System.Windows.Forms.TextBox txtSetTimerInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

