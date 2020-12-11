namespace Lab3Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.CarName = new System.Windows.Forms.TextBox();
            this.SearchByName = new System.Windows.Forms.Button();
            this.SearchAllOutput = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.sortPrice = new System.Windows.Forms.Button();
            this.OldName = new System.Windows.Forms.TextBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.NewModel = new System.Windows.Forms.TextBox();
            this.NewPrice = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(118, 15);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(112, 26);
            this.Name.TabIndex = 1;
            // 
            // Position
            // 
            this.Model.Location = new System.Drawing.Point(118, 51);
            this.Model.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(112, 26);
            this.Model.TabIndex = 2;
            // 
            // Salary
            // 
            this.Price.Location = new System.Drawing.Point(118, 88);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(112, 26);
            this.Price.TabIndex = 3;
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(118, 138);
            this.AddCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(112, 29);
            this.AddCar.TabIndex = 4;
            this.AddCar.Text = "Add car";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click_1);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(444, 14);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(84, 29);
            this.ShowAll.TabIndex = 5;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // WorkerName
            // 
            this.CarName.Location = new System.Drawing.Point(272, 16);
            this.CarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(112, 26);
            this.CarName.TabIndex = 6;
            // 
            // SearchByName
            // 
            this.SearchByName.Location = new System.Drawing.Point(272, 51);
            this.SearchByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(146, 29);
            this.SearchByName.TabIndex = 7;
            this.SearchByName.Text = "Search by name";
            this.SearchByName.UseVisualStyleBackColor = true;
            this.SearchByName.Click += new System.EventHandler(this.SearchByName_Click);
            // 
            // SearchAllOutput
            // 
            this.SearchAllOutput.AcceptsReturn = true;
            this.SearchAllOutput.Location = new System.Drawing.Point(15, 219);
            this.SearchAllOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchAllOutput.Multiline = true;
            this.SearchAllOutput.Name = "SearchAllOutput";
            this.SearchAllOutput.Size = new System.Drawing.Size(550, 240);
            this.SearchAllOutput.TabIndex = 9;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(272, 88);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(84, 29);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // sortPrice
            // 
            this.sortPrice.Location = new System.Drawing.Point(444, 50);
            this.sortPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortPrice.Name = "sortPrice";
            this.sortPrice.Size = new System.Drawing.Size(120, 29);
            this.sortPrice.TabIndex = 11;
            this.sortPrice.Text = "Sort by price";
            this.sortPrice.UseVisualStyleBackColor = true;
            this.sortPrice.Click += new System.EventHandler(this.button2_Click);
            // 
            // OldName
            // 
            this.OldName.Location = new System.Drawing.Point(616, 16);
            this.OldName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OldName.Name = "OldName";
            this.OldName.Size = new System.Drawing.Size(112, 26);
            this.OldName.TabIndex = 12;
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(616, 50);
            this.NewName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(112, 26);
            this.NewName.TabIndex = 13;
            // 
            // NewPosition
            // 
            this.NewModel.Location = new System.Drawing.Point(616, 88);
            this.NewModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewModel.Name = "NewModel";
            this.NewModel.Size = new System.Drawing.Size(112, 26);
            this.NewModel.TabIndex = 14;
            // 
            // NewSalary
            // 
            this.NewPrice.Location = new System.Drawing.Point(616, 124);
            this.NewPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(112, 26);
            this.NewPrice.TabIndex = 15;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(616, 160);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(84, 29);
            this.Edit.TabIndex = 16;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(15, 50);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(97, 29);
            this.Disconnect.TabIndex = 17;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.NewPrice);
            this.Controls.Add(this.NewModel);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.OldName);
            this.Controls.Add(this.sortPrice);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SearchAllOutput);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.TextBox CarName;
        private System.Windows.Forms.Button SearchByName;
        private System.Windows.Forms.TextBox SearchAllOutput;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button sortPrice;
        private System.Windows.Forms.TextBox OldName;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox NewModel;
        private System.Windows.Forms.TextBox NewPrice;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Disconnect;
    }
}

