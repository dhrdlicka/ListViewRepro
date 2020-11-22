namespace ListViewRepro
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader fruitColumnHeader;
            System.Windows.Forms.ImageList imageList;
            System.Windows.Forms.ColumnHeader lengthColumnHeader;
            System.Windows.Forms.ColumnHeader distinctLettersColumnHeader;
            this.listView = new System.Windows.Forms.ListView();
            fruitColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            imageList = new System.Windows.Forms.ImageList(this.components);
            lengthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            distinctLettersColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // fruitColumnHeader
            // 
            fruitColumnHeader.Text = "Fruit";
            fruitColumnHeader.Width = 100;
            // 
            // imageList
            // 
            imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList.ImageSize = new System.Drawing.Size(16, 16);
            imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lengthColumnHeader
            // 
            lengthColumnHeader.Text = "Length";
            lengthColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            lengthColumnHeader.Width = 100;
            // 
            // distinctLettersColumnHeader
            // 
            distinctLettersColumnHeader.Text = "Distinct letters";
            distinctLettersColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            distinctLettersColumnHeader.Width = 100;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            fruitColumnHeader,
            lengthColumnHeader,
            distinctLettersColumnHeader});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = imageList;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(686, 390);
            this.listView.SmallImageList = imageList;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.listView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
    }
}

