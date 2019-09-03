namespace CRUD_with_code
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_available = new System.Windows.Forms.RadioButton();
            this.rad_notavailable = new System.Windows.Forms.RadioButton();
            this.bttn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dgv_pizza = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_ingredients = new System.Windows.Forms.TextBox();
            this.txt_enterID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pizza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingredients:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_notavailable);
            this.groupBox1.Controls.Add(this.rad_available);
            this.groupBox1.Location = new System.Drawing.Point(67, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Availability";
            // 
            // rad_available
            // 
            this.rad_available.AutoSize = true;
            this.rad_available.Location = new System.Drawing.Point(7, 30);
            this.rad_available.Name = "rad_available";
            this.rad_available.Size = new System.Drawing.Size(68, 17);
            this.rad_available.TabIndex = 0;
            this.rad_available.TabStop = true;
            this.rad_available.Text = "Available";
            this.rad_available.UseVisualStyleBackColor = true;
            // 
            // rad_notavailable
            // 
            this.rad_notavailable.AutoSize = true;
            this.rad_notavailable.Location = new System.Drawing.Point(6, 67);
            this.rad_notavailable.Name = "rad_notavailable";
            this.rad_notavailable.Size = new System.Drawing.Size(88, 17);
            this.rad_notavailable.TabIndex = 1;
            this.rad_notavailable.TabStop = true;
            this.rad_notavailable.Text = "Not Available";
            this.rad_notavailable.UseVisualStyleBackColor = true;
            // 
            // bttn_insert
            // 
            this.bttn_insert.Location = new System.Drawing.Point(67, 370);
            this.bttn_insert.Name = "bttn_insert";
            this.bttn_insert.Size = new System.Drawing.Size(75, 23);
            this.bttn_insert.TabIndex = 6;
            this.bttn_insert.Text = "Insert";
            this.bttn_insert.UseVisualStyleBackColor = true;
            this.bttn_insert.Click += new System.EventHandler(this.bttn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(67, 415);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(178, 370);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(178, 415);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_pizza
            // 
            this.dgv_pizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pizza.Location = new System.Drawing.Point(324, 236);
            this.dgv_pizza.Name = "dgv_pizza";
            this.dgv_pizza.Size = new System.Drawing.Size(335, 128);
            this.dgv_pizza.TabIndex = 10;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(126, 96);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(126, 142);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 12;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(126, 187);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 13;
            // 
            // txt_ingredients
            // 
            this.txt_ingredients.Location = new System.Drawing.Point(126, 225);
            this.txt_ingredients.Name = "txt_ingredients";
            this.txt_ingredients.Size = new System.Drawing.Size(100, 20);
            this.txt_ingredients.TabIndex = 14;
            // 
            // txt_enterID
            // 
            this.txt_enterID.Location = new System.Drawing.Point(449, 190);
            this.txt_enterID.Name = "txt_enterID";
            this.txt_enterID.Size = new System.Drawing.Size(100, 20);
            this.txt_enterID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter pizza ID:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(567, 188);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(449, 384);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(75, 23);
            this.btn_fetch.TabIndex = 18;
            this.btn_fetch.Text = "Fetch";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_enterID);
            this.Controls.Add(this.txt_ingredients);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.dgv_pizza);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.bttn_insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_notavailable;
        private System.Windows.Forms.RadioButton rad_available;
        private System.Windows.Forms.Button bttn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_pizza;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_ingredients;
        private System.Windows.Forms.TextBox txt_enterID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_fetch;
    }
}

