namespace usingPlaceHolderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.placeholderTextBox1 = new CustomControls.PlaceholderTextBox();
            this.searchTextBox1 = new CustomControls.SearchTextBox();
            this.SuspendLayout();
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Location = new System.Drawing.Point(53, 53);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceHolderFieldRequired = false;
            this.placeholderTextBox1.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.PlaceHolderText = "Search";
            this.placeholderTextBox1.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox1.TabIndex = 1;
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.CancelSearchImage = global::usingPlaceHolderControl.Properties.Resources.delete_icon;
            this.searchTextBox1.Location = new System.Drawing.Point(170, 53);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.PlaceHolderFieldRequired = false;
            this.searchTextBox1.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox1.PlaceHolderText = "Search";
            this.searchTextBox1.SearchImage = global::usingPlaceHolderControl.Properties.Resources.search_icon1;
            this.searchTextBox1.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox1);
            this.Controls.Add(this.placeholderTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.PlaceholderTextBox placeholderTextBox1;
        private CustomControls.SearchTextBox searchTextBox1;
    }
}

