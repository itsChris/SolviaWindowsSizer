namespace SolviaWindowsSizer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listViewWindows = new System.Windows.Forms.ListView();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelHints2 = new System.Windows.Forms.Label();
            this.labelHints1 = new System.Windows.Forms.Label();
            this.labelHintsHeader = new System.Windows.Forms.Label();
            this.labelWindows = new System.Windows.Forms.Label();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewWindows
            // 
            this.listViewWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWindows.HideSelection = false;
            this.listViewWindows.Location = new System.Drawing.Point(16, 45);
            this.listViewWindows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewWindows.Name = "listViewWindows";
            this.listViewWindows.Size = new System.Drawing.Size(930, 892);
            this.listViewWindows.TabIndex = 1;
            this.listViewWindows.UseCompatibleStateImageBehavior = false;
            this.listViewWindows.View = System.Windows.Forms.View.Details;
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(1041, 45);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(124, 27);
            this.textBoxX.TabIndex = 2;
            this.textBoxX.Text = "1920";
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(1041, 76);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(124, 27);
            this.textBoxY.TabIndex = 3;
            this.textBoxY.Text = "1080";
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(978, 49);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 18);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(978, 80);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 18);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y:";
            // 
            // labelHints2
            // 
            this.labelHints2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHints2.AutoEllipsis = true;
            this.labelHints2.AutoSize = true;
            this.labelHints2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHints2.Location = new System.Drawing.Point(13, 1007);
            this.labelHints2.Name = "labelHints2";
            this.labelHints2.Size = new System.Drawing.Size(1067, 18);
            this.labelHints2.TabIndex = 6;
            this.labelHints2.Text = "After refreshing, if you select any item within the ListView, its display size wi" +
    "ll adjust based on predefined X and Y dimensions.";
            // 
            // labelHints1
            // 
            this.labelHints1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHints1.AutoEllipsis = true;
            this.labelHints1.AutoSize = true;
            this.labelHints1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHints1.Location = new System.Drawing.Point(13, 983);
            this.labelHints1.Name = "labelHints1";
            this.labelHints1.Size = new System.Drawing.Size(450, 18);
            this.labelHints1.TabIndex = 7;
            this.labelHints1.Text = "Pressing F5 will refresh the contents of the ListView. ";
            // 
            // labelHintsHeader
            // 
            this.labelHintsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHintsHeader.AutoEllipsis = true;
            this.labelHintsHeader.AutoSize = true;
            this.labelHintsHeader.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHintsHeader.Location = new System.Drawing.Point(13, 958);
            this.labelHintsHeader.Name = "labelHintsHeader";
            this.labelHintsHeader.Size = new System.Drawing.Size(58, 18);
            this.labelHintsHeader.TabIndex = 8;
            this.labelHintsHeader.Text = "Hints:";
            // 
            // labelWindows
            // 
            this.labelWindows.AutoEllipsis = true;
            this.labelWindows.AutoSize = true;
            this.labelWindows.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindows.Location = new System.Drawing.Point(13, 16);
            this.labelWindows.Name = "labelWindows";
            this.labelWindows.Size = new System.Drawing.Size(203, 18);
            this.labelWindows.TabIndex = 9;
            this.labelWindows.Text = "Windows/Applications";
            // 
            // labelDimensions
            // 
            this.labelDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDimensions.AutoEllipsis = true;
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimensions.Location = new System.Drawing.Point(980, 8);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(154, 18);
            this.labelDimensions.TabIndex = 10;
            this.labelDimensions.Text = "Size/Dimensions";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 1033);
            this.Controls.Add(this.labelDimensions);
            this.Controls.Add(this.labelWindows);
            this.Controls.Add(this.labelHintsHeader);
            this.Controls.Add(this.labelHints1);
            this.Controls.Add(this.labelHints2);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.listViewWindows);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 480);
            this.Name = "FormMain";
            this.Text = "Solvia - Windows Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewWindows;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelHints2;
        private System.Windows.Forms.Label labelHints1;
        private System.Windows.Forms.Label labelHintsHeader;
        private System.Windows.Forms.Label labelWindows;
        private System.Windows.Forms.Label labelDimensions;
    }
}

