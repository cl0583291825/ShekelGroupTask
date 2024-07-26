namespace Northwind.Views.Controls.Test.Views
{
    partial class TestView
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
            this.grid2 = new Northwind.Shared.Theme.Controls.Grid();
            this.grid1 = new Northwind.Shared.Theme.Controls.Grid();
            this.gcProductID = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductID = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcProductName = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductName = new Northwind.Shared.Theme.Controls.TextBox();
            this.grid1.SuspendLayout();
            this.gcProductID.SuspendLayout();
            this.gcProductName.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid2
            // 
            this.grid2.Location = new System.Drawing.Point(0, 0);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(240, 150);
            this.grid2.TabIndex = 0;
            this.grid2.Text = "grid2";
            // 
            // grid1
            // 
            this.grid1.Controls.Add(this.gcProductID);
            this.grid1.Controls.Add(this.gcProductName);
            this.grid1.Location = new System.Drawing.Point(3, 12);
            this.grid1.Name = "grid1";
            this.grid1.RowHeight = 31;
            this.grid1.Size = new System.Drawing.Size(265, 424);
            this.grid1.Text = "grid1";
            // 
            // gcProductID
            // 
            this.gcProductID.Controls.Add(this.txtProductID);
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.Text = "ProductID";
            this.gcProductID.Width = 95;
            // 
            // txtProductID
            // 
            this.txtProductID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductID.Location = new System.Drawing.Point(2, 1);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(191, 30);
            this.txtProductID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductID.Data = this._controller.Products.ProductID;
            // 
            // gcProductName
            // 
            this.gcProductName.Controls.Add(this.txtProductName);
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.Text = "ProductName";
            this.gcProductName.Width = 435;
            // 
            // txtProductName
            // 
            this.txtProductName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductName.Location = new System.Drawing.Point(2, 1);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(143, 30);
            this.txtProductName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductName.Data = this._controller.Products.ProductName;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 447);
            this.Controls.Add(this.grid1);
            this.HorizontalExpressionFactor = 1D;
            this.Name = "TestView";
            this.StartPosition = Firefly.Box.UI.WindowStartPosition.Default;
            this.Text = "Test";
            this.VerticalExpressionFactor = 1D;
            this.grid1.ResumeLayout(false);
            this.gcProductID.ResumeLayout(false);
            this.gcProductName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Shared.Theme.Controls.Grid grid2;
        private Shared.Theme.Controls.Grid grid1;
        private Shared.Theme.Controls.GridColumn gcProductID;
        private Shared.Theme.Controls.TextBox txtProductID;
        private Shared.Theme.Controls.GridColumn gcProductName;
        private Shared.Theme.Controls.TextBox txtProductName;
    }
}