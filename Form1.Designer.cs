
namespace Pizzaproject
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
            this.gbsize = new System.Windows.Forms.GroupBox();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmedium = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbcrust = new System.Windows.Forms.GroupBox();
            this.rbthick = new System.Windows.Forms.RadioButton();
            this.rbthin = new System.Windows.Forms.RadioButton();
            this.gbtopping = new System.Windows.Forms.GroupBox();
            this.chkolives = new System.Windows.Forms.CheckBox();
            this.Chkgreenp = new System.Windows.Forms.CheckBox();
            this.chkonion = new System.Windows.Forms.CheckBox();
            this.chktomato = new System.Windows.Forms.CheckBox();
            this.chkmushrum = new System.Windows.Forms.CheckBox();
            this.chkcheese = new System.Windows.Forms.CheckBox();
            this.gbplace = new System.Windows.Forms.GroupBox();
            this.rbout = new System.Windows.Forms.RadioButton();
            this.rbin = new System.Windows.Forms.RadioButton();
            this.btorder = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.gbsummary = new System.Windows.Forms.GroupBox();
            this.lbanswertopping = new System.Windows.Forms.Label();
            this.lbanswerprice = new System.Windows.Forms.Label();
            this.lbanswerplace = new System.Windows.Forms.Label();
            this.lbanswercrust = new System.Windows.Forms.Label();
            this.lbanswersize = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbplace = new System.Windows.Forms.Label();
            this.lbtopping = new System.Windows.Forms.Label();
            this.lbcrust = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbsize.SuspendLayout();
            this.gbcrust.SuspendLayout();
            this.gbtopping.SuspendLayout();
            this.gbplace.SuspendLayout();
            this.gbsummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsize
            // 
            this.gbsize.Controls.Add(this.rblarge);
            this.gbsize.Controls.Add(this.rbmedium);
            this.gbsize.Controls.Add(this.rbsmall);
            this.gbsize.ForeColor = System.Drawing.Color.Maroon;
            this.gbsize.Location = new System.Drawing.Point(146, 130);
            this.gbsize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbsize.Name = "gbsize";
            this.gbsize.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbsize.Size = new System.Drawing.Size(314, 226);
            this.gbsize.TabIndex = 0;
            this.gbsize.TabStop = false;
            this.gbsize.Text = "Size";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Location = new System.Drawing.Point(41, 148);
            this.rblarge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(74, 25);
            this.rblarge.TabIndex = 2;
            this.rblarge.Tag = "40";
            this.rblarge.Text = "large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.Checked = true;
            this.rbmedium.Location = new System.Drawing.Point(41, 97);
            this.rbmedium.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(99, 25);
            this.rbmedium.TabIndex = 1;
            this.rbmedium.TabStop = true;
            this.rbmedium.Tag = "30";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = true;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbmedium_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Location = new System.Drawing.Point(41, 39);
            this.rbsmall.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(76, 25);
            this.rbsmall.TabIndex = 0;
            this.rbsmall.Tag = "20";
            this.rbsmall.Text = "small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // gbcrust
            // 
            this.gbcrust.Controls.Add(this.rbthick);
            this.gbcrust.Controls.Add(this.rbthin);
            this.gbcrust.ForeColor = System.Drawing.Color.Maroon;
            this.gbcrust.Location = new System.Drawing.Point(146, 442);
            this.gbcrust.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbcrust.Name = "gbcrust";
            this.gbcrust.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbcrust.Size = new System.Drawing.Size(314, 200);
            this.gbcrust.TabIndex = 1;
            this.gbcrust.TabStop = false;
            this.gbcrust.Text = "Crust Type";
            // 
            // rbthick
            // 
            this.rbthick.AutoSize = true;
            this.rbthick.Location = new System.Drawing.Point(41, 151);
            this.rbthick.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbthick.Name = "rbthick";
            this.rbthick.Size = new System.Drawing.Size(76, 25);
            this.rbthick.TabIndex = 1;
            this.rbthick.Tag = "10";
            this.rbthick.Text = "Thick";
            this.rbthick.UseVisualStyleBackColor = true;
            this.rbthick.CheckedChanged += new System.EventHandler(this.rbthick_CheckedChanged);
            // 
            // rbthin
            // 
            this.rbthin.AutoSize = true;
            this.rbthin.Checked = true;
            this.rbthin.Location = new System.Drawing.Point(41, 75);
            this.rbthin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(65, 25);
            this.rbthin.TabIndex = 0;
            this.rbthin.TabStop = true;
            this.rbthin.Tag = "0";
            this.rbthin.Text = "thin";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // gbtopping
            // 
            this.gbtopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbtopping.Controls.Add(this.chkolives);
            this.gbtopping.Controls.Add(this.Chkgreenp);
            this.gbtopping.Controls.Add(this.chkonion);
            this.gbtopping.Controls.Add(this.chktomato);
            this.gbtopping.Controls.Add(this.chkmushrum);
            this.gbtopping.Controls.Add(this.chkcheese);
            this.gbtopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbtopping.ForeColor = System.Drawing.Color.Maroon;
            this.gbtopping.Location = new System.Drawing.Point(596, 130);
            this.gbtopping.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbtopping.Name = "gbtopping";
            this.gbtopping.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbtopping.Size = new System.Drawing.Size(437, 226);
            this.gbtopping.TabIndex = 2;
            this.gbtopping.TabStop = false;
            this.gbtopping.Text = "topping";
            // 
            // chkolives
            // 
            this.chkolives.AutoSize = true;
            this.chkolives.Location = new System.Drawing.Point(258, 167);
            this.chkolives.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkolives.Name = "chkolives";
            this.chkolives.Size = new System.Drawing.Size(84, 25);
            this.chkolives.TabIndex = 5;
            this.chkolives.Tag = "5";
            this.chkolives.Text = "Olives";
            this.chkolives.UseVisualStyleBackColor = true;
            this.chkolives.CheckedChanged += new System.EventHandler(this.chkolives_CheckedChanged);
            // 
            // Chkgreenp
            // 
            this.Chkgreenp.AutoSize = true;
            this.Chkgreenp.Location = new System.Drawing.Point(258, 102);
            this.Chkgreenp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Chkgreenp.Name = "Chkgreenp";
            this.Chkgreenp.Size = new System.Drawing.Size(137, 25);
            this.Chkgreenp.TabIndex = 3;
            this.Chkgreenp.Tag = "5";
            this.Chkgreenp.Text = "Green Paper";
            this.Chkgreenp.UseVisualStyleBackColor = true;
            this.Chkgreenp.CheckedChanged += new System.EventHandler(this.Chkgreenp_CheckedChanged);
            // 
            // chkonion
            // 
            this.chkonion.AutoSize = true;
            this.chkonion.Location = new System.Drawing.Point(258, 42);
            this.chkonion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkonion.Name = "chkonion";
            this.chkonion.Size = new System.Drawing.Size(83, 25);
            this.chkonion.TabIndex = 1;
            this.chkonion.Tag = "5";
            this.chkonion.Text = "Onion";
            this.chkonion.UseVisualStyleBackColor = true;
            this.chkonion.CheckedChanged += new System.EventHandler(this.chkonion_CheckedChanged);
            // 
            // chktomato
            // 
            this.chktomato.AutoSize = true;
            this.chktomato.Location = new System.Drawing.Point(25, 167);
            this.chktomato.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chktomato.Name = "chktomato";
            this.chktomato.Size = new System.Drawing.Size(97, 25);
            this.chktomato.TabIndex = 4;
            this.chktomato.Tag = "5";
            this.chktomato.Text = "Tomato";
            this.chktomato.UseVisualStyleBackColor = true;
            this.chktomato.CheckedChanged += new System.EventHandler(this.chktomato_CheckedChanged);
            // 
            // chkmushrum
            // 
            this.chkmushrum.AutoSize = true;
            this.chkmushrum.Location = new System.Drawing.Point(25, 102);
            this.chkmushrum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkmushrum.Name = "chkmushrum";
            this.chkmushrum.Size = new System.Drawing.Size(112, 25);
            this.chkmushrum.TabIndex = 2;
            this.chkmushrum.Tag = "5";
            this.chkmushrum.Text = "Mushrum";
            this.chkmushrum.UseVisualStyleBackColor = true;
            this.chkmushrum.CheckedChanged += new System.EventHandler(this.chkmushrum_CheckedChanged);
            // 
            // chkcheese
            // 
            this.chkcheese.AutoSize = true;
            this.chkcheese.Location = new System.Drawing.Point(25, 42);
            this.chkcheese.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkcheese.Name = "chkcheese";
            this.chkcheese.Size = new System.Drawing.Size(142, 25);
            this.chkcheese.TabIndex = 0;
            this.chkcheese.Tag = "5";
            this.chkcheese.Text = "Extra Cheese";
            this.chkcheese.UseVisualStyleBackColor = true;
            this.chkcheese.CheckedChanged += new System.EventHandler(this.chkcheese_CheckedChanged);
            // 
            // gbplace
            // 
            this.gbplace.Controls.Add(this.rbout);
            this.gbplace.Controls.Add(this.rbin);
            this.gbplace.ForeColor = System.Drawing.Color.Maroon;
            this.gbplace.Location = new System.Drawing.Point(596, 442);
            this.gbplace.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbplace.Name = "gbplace";
            this.gbplace.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbplace.Size = new System.Drawing.Size(437, 200);
            this.gbplace.TabIndex = 1;
            this.gbplace.TabStop = false;
            this.gbplace.Text = "where to eat?";
            // 
            // rbout
            // 
            this.rbout.AutoSize = true;
            this.rbout.Location = new System.Drawing.Point(35, 136);
            this.rbout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbout.Name = "rbout";
            this.rbout.Size = new System.Drawing.Size(107, 25);
            this.rbout.TabIndex = 1;
            this.rbout.Text = "Take Out";
            this.rbout.UseVisualStyleBackColor = true;
            this.rbout.CheckedChanged += new System.EventHandler(this.rbout_CheckedChanged);
            // 
            // rbin
            // 
            this.rbin.AutoSize = true;
            this.rbin.Location = new System.Drawing.Point(35, 63);
            this.rbin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbin.Name = "rbin";
            this.rbin.Size = new System.Drawing.Size(79, 25);
            this.rbin.TabIndex = 0;
            this.rbin.Text = "Eat in";
            this.rbin.UseVisualStyleBackColor = true;
            this.rbin.CheckedChanged += new System.EventHandler(this.rbin_CheckedChanged);
            // 
            // btorder
            // 
            this.btorder.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btorder.Location = new System.Drawing.Point(465, 755);
            this.btorder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btorder.Name = "btorder";
            this.btorder.Size = new System.Drawing.Size(264, 89);
            this.btorder.TabIndex = 4;
            this.btorder.Text = "Order Pizza";
            this.btorder.UseVisualStyleBackColor = true;
            this.btorder.Click += new System.EventHandler(this.btorder_Click);
            // 
            // btreset
            // 
            this.btreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btreset.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.Location = new System.Drawing.Point(943, 755);
            this.btreset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(286, 89);
            this.btreset.TabIndex = 5;
            this.btreset.Text = "Reset Form";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // gbsummary
            // 
            this.gbsummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbsummary.Controls.Add(this.lbanswertopping);
            this.gbsummary.Controls.Add(this.lbanswerprice);
            this.gbsummary.Controls.Add(this.lbanswerplace);
            this.gbsummary.Controls.Add(this.lbanswercrust);
            this.gbsummary.Controls.Add(this.lbanswersize);
            this.gbsummary.Controls.Add(this.lbprice);
            this.gbsummary.Controls.Add(this.lbplace);
            this.gbsummary.Controls.Add(this.lbtopping);
            this.gbsummary.Controls.Add(this.lbcrust);
            this.gbsummary.Controls.Add(this.lb);
            this.gbsummary.ForeColor = System.Drawing.Color.Maroon;
            this.gbsummary.Location = new System.Drawing.Point(1094, 130);
            this.gbsummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbsummary.Name = "gbsummary";
            this.gbsummary.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbsummary.Size = new System.Drawing.Size(589, 479);
            this.gbsummary.TabIndex = 3;
            this.gbsummary.TabStop = false;
            this.gbsummary.Text = "Order summary";
            // 
            // lbanswertopping
            // 
            this.lbanswertopping.AutoSize = true;
            this.lbanswertopping.Location = new System.Drawing.Point(109, 206);
            this.lbanswertopping.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbanswertopping.Name = "lbanswertopping";
            this.lbanswertopping.Size = new System.Drawing.Size(17, 21);
            this.lbanswertopping.TabIndex = 10;
            this.lbanswertopping.Text = "-";
            // 
            // lbanswerprice
            // 
            this.lbanswerprice.AutoSize = true;
            this.lbanswerprice.Location = new System.Drawing.Point(192, 419);
            this.lbanswerprice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbanswerprice.Name = "lbanswerprice";
            this.lbanswerprice.Size = new System.Drawing.Size(32, 21);
            this.lbanswerprice.TabIndex = 9;
            this.lbanswerprice.Text = "0$";
            this.lbanswerprice.Click += new System.EventHandler(this.lbanswerprice_Click);
            // 
            // lbanswerplace
            // 
            this.lbanswerplace.AutoSize = true;
            this.lbanswerplace.Location = new System.Drawing.Point(206, 320);
            this.lbanswerplace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbanswerplace.Name = "lbanswerplace";
            this.lbanswerplace.Size = new System.Drawing.Size(17, 21);
            this.lbanswerplace.TabIndex = 8;
            this.lbanswerplace.Text = "-";
            // 
            // lbanswercrust
            // 
            this.lbanswercrust.AutoSize = true;
            this.lbanswercrust.Location = new System.Drawing.Point(165, 114);
            this.lbanswercrust.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbanswercrust.Name = "lbanswercrust";
            this.lbanswercrust.Size = new System.Drawing.Size(17, 21);
            this.lbanswercrust.TabIndex = 6;
            this.lbanswercrust.Text = "-";
            // 
            // lbanswersize
            // 
            this.lbanswersize.AutoSize = true;
            this.lbanswersize.Location = new System.Drawing.Point(94, 42);
            this.lbanswersize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbanswersize.Name = "lbanswersize";
            this.lbanswersize.Size = new System.Drawing.Size(17, 21);
            this.lbanswersize.TabIndex = 5;
            this.lbanswersize.Text = "-";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(28, 419);
            this.lbprice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(111, 21);
            this.lbprice.TabIndex = 4;
            this.lbprice.Text = "Total Price: ";
            // 
            // lbplace
            // 
            this.lbplace.AutoSize = true;
            this.lbplace.Location = new System.Drawing.Point(28, 320);
            this.lbplace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbplace.Name = "lbplace";
            this.lbplace.Size = new System.Drawing.Size(126, 21);
            this.lbplace.TabIndex = 3;
            this.lbplace.Text = "Where to eat:";
            // 
            // lbtopping
            // 
            this.lbtopping.AutoSize = true;
            this.lbtopping.Location = new System.Drawing.Point(28, 206);
            this.lbtopping.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbtopping.Name = "lbtopping";
            this.lbtopping.Size = new System.Drawing.Size(86, 21);
            this.lbtopping.TabIndex = 2;
            this.lbtopping.Text = "Topping:";
            // 
            // lbcrust
            // 
            this.lbcrust.AutoSize = true;
            this.lbcrust.Location = new System.Drawing.Point(28, 114);
            this.lbcrust.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbcrust.Name = "lbcrust";
            this.lbcrust.Size = new System.Drawing.Size(107, 21);
            this.lbcrust.TabIndex = 1;
            this.lbcrust.Text = "Crust Type:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(28, 45);
            this.lb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(51, 21);
            this.lb.TabIndex = 0;
            this.lb.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(501, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(435, 51);
            this.label6.TabIndex = 0;
            this.label6.Text = "Make Your Own Pizza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1795, 895);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btorder);
            this.Controls.Add(this.gbsummary);
            this.Controls.Add(this.gbplace);
            this.Controls.Add(this.gbtopping);
            this.Controls.Add(this.gbcrust);
            this.Controls.Add(this.gbsize);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.gbsize.ResumeLayout(false);
            this.gbsize.PerformLayout();
            this.gbcrust.ResumeLayout(false);
            this.gbcrust.PerformLayout();
            this.gbtopping.ResumeLayout(false);
            this.gbtopping.PerformLayout();
            this.gbplace.ResumeLayout(false);
            this.gbplace.PerformLayout();
            this.gbsummary.ResumeLayout(false);
            this.gbsummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbcrust;
        private System.Windows.Forms.GroupBox gbtopping;
        private System.Windows.Forms.GroupBox gbplace;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmedium;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.RadioButton rbthick;
        private System.Windows.Forms.RadioButton rbthin;
        private System.Windows.Forms.RadioButton rbout;
        private System.Windows.Forms.RadioButton rbin;
        private System.Windows.Forms.CheckBox Chkgreenp;
        private System.Windows.Forms.CheckBox chkonion;
        private System.Windows.Forms.CheckBox chktomato;
        private System.Windows.Forms.CheckBox chkmushrum;
        private System.Windows.Forms.CheckBox chkcheese;
        private System.Windows.Forms.CheckBox chkolives;
        private System.Windows.Forms.Button btorder;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.GroupBox gbsummary;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbplace;
        private System.Windows.Forms.Label lbtopping;
        private System.Windows.Forms.Label lbcrust;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbanswerprice;
        private System.Windows.Forms.Label lbanswerplace;
        private System.Windows.Forms.Label lbanswercrust;
        private System.Windows.Forms.Label lbanswersize;
        private System.Windows.Forms.Label lbanswertopping;
    }
}

