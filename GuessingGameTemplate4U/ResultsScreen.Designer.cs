namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalGuessesLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numOfGuessesLabel = new System.Windows.Forms.Label();
            this.sortedGuessesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalGuessesLabel
            // 
            this.originalGuessesLabel.BackColor = System.Drawing.Color.Transparent;
            this.originalGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalGuessesLabel.ForeColor = System.Drawing.Color.White;
            this.originalGuessesLabel.Location = new System.Drawing.Point(39, 185);
            this.originalGuessesLabel.Name = "originalGuessesLabel";
            this.originalGuessesLabel.Size = new System.Drawing.Size(321, 65);
            this.originalGuessesLabel.TabIndex = 0;
            this.originalGuessesLabel.Text = "Original Order:";
            this.originalGuessesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(133, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(109, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Results";
            // 
            // numOfGuessesLabel
            // 
            this.numOfGuessesLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOfGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfGuessesLabel.ForeColor = System.Drawing.Color.White;
            this.numOfGuessesLabel.Location = new System.Drawing.Point(39, 111);
            this.numOfGuessesLabel.Name = "numOfGuessesLabel";
            this.numOfGuessesLabel.Size = new System.Drawing.Size(321, 65);
            this.numOfGuessesLabel.TabIndex = 2;
            this.numOfGuessesLabel.Text = "Guesses made: ";
            // 
            // sortedGuessesLabel
            // 
            this.sortedGuessesLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortedGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedGuessesLabel.ForeColor = System.Drawing.Color.White;
            this.sortedGuessesLabel.Location = new System.Drawing.Point(39, 264);
            this.sortedGuessesLabel.Name = "sortedGuessesLabel";
            this.sortedGuessesLabel.Size = new System.Drawing.Size(321, 65);
            this.sortedGuessesLabel.TabIndex = 3;
            this.sortedGuessesLabel.Text = "Sorted Order:";
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortedGuessesLabel);
            this.Controls.Add(this.numOfGuessesLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.originalGuessesLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(400, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalGuessesLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numOfGuessesLabel;
        private System.Windows.Forms.Label sortedGuessesLabel;
    }
}
