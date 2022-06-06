
namespace Animal_Battle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_choose = new System.Windows.Forms.Button();
            this.second_characters = new System.Windows.Forms.ListBox();
            this.second_animal = new System.Windows.Forms.ComboBox();
            this.first_characters = new System.Windows.Forms.ListBox();
            this.first_animal = new System.Windows.Forms.ComboBox();
            this.all_characteristics = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.show_characters = new System.Windows.Forms.Button();
            this.change_second_character = new System.Windows.Forms.ComboBox();
            this.change_first_character = new System.Windows.Forms.ComboBox();
            this.new_first_character_value = new System.Windows.Forms.TextBox();
            this.new_second_character_value = new System.Windows.Forms.TextBox();
            this.fir_choose_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sec_choose_label = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.start_battle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose your animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose your animal";
            // 
            // confirm_choose
            // 
            this.confirm_choose.AutoSize = true;
            this.confirm_choose.Location = new System.Drawing.Point(12, 217);
            this.confirm_choose.Name = "confirm_choose";
            this.confirm_choose.Size = new System.Drawing.Size(132, 23);
            this.confirm_choose.TabIndex = 12;
            this.confirm_choose.Text = "Confirm your choose";
            this.confirm_choose.UseVisualStyleBackColor = true;
            this.confirm_choose.Click += new System.EventHandler(this.confirm_choose_Click);
            // 
            // second_characters
            // 
            this.second_characters.FormattingEnabled = true;
            this.second_characters.Location = new System.Drawing.Point(229, 64);
            this.second_characters.Name = "second_characters";
            this.second_characters.Size = new System.Drawing.Size(136, 147);
            this.second_characters.TabIndex = 11;
            // 
            // second_animal
            // 
            this.second_animal.FormattingEnabled = true;
            this.second_animal.Location = new System.Drawing.Point(229, 37);
            this.second_animal.Name = "second_animal";
            this.second_animal.Size = new System.Drawing.Size(136, 21);
            this.second_animal.TabIndex = 10;
            // 
            // first_characters
            // 
            this.first_characters.FormattingEnabled = true;
            this.first_characters.Location = new System.Drawing.Point(12, 64);
            this.first_characters.Name = "first_characters";
            this.first_characters.Size = new System.Drawing.Size(132, 147);
            this.first_characters.TabIndex = 9;
            // 
            // first_animal
            // 
            this.first_animal.FormattingEnabled = true;
            this.first_animal.Location = new System.Drawing.Point(12, 37);
            this.first_animal.Name = "first_animal";
            this.first_animal.Size = new System.Drawing.Size(132, 21);
            this.first_animal.TabIndex = 8;
            // 
            // all_characteristics
            // 
            this.all_characteristics.FormattingEnabled = true;
            this.all_characteristics.Location = new System.Drawing.Point(419, 64);
            this.all_characteristics.Name = "all_characteristics";
            this.all_characteristics.Size = new System.Drawing.Size(297, 147);
            this.all_characteristics.TabIndex = 15;
            this.all_characteristics.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "All characteristics";
            this.label3.Visible = false;
            // 
            // show_characters
            // 
            this.show_characters.AutoSize = true;
            this.show_characters.Location = new System.Drawing.Point(229, 217);
            this.show_characters.Name = "show_characters";
            this.show_characters.Size = new System.Drawing.Size(136, 23);
            this.show_characters.TabIndex = 17;
            this.show_characters.Text = "Show all characteristics";
            this.show_characters.UseVisualStyleBackColor = true;
            this.show_characters.Click += new System.EventHandler(this.show_characters_Click);
            // 
            // change_second_character
            // 
            this.change_second_character.FormattingEnabled = true;
            this.change_second_character.Location = new System.Drawing.Point(229, 312);
            this.change_second_character.Name = "change_second_character";
            this.change_second_character.Size = new System.Drawing.Size(136, 21);
            this.change_second_character.TabIndex = 19;
            this.change_second_character.Visible = false;
            // 
            // change_first_character
            // 
            this.change_first_character.FormattingEnabled = true;
            this.change_first_character.Location = new System.Drawing.Point(12, 312);
            this.change_first_character.Name = "change_first_character";
            this.change_first_character.Size = new System.Drawing.Size(132, 21);
            this.change_first_character.TabIndex = 18;
            this.change_first_character.Visible = false;
            // 
            // new_first_character_value
            // 
            this.new_first_character_value.Location = new System.Drawing.Point(12, 339);
            this.new_first_character_value.Name = "new_first_character_value";
            this.new_first_character_value.Size = new System.Drawing.Size(132, 20);
            this.new_first_character_value.TabIndex = 20;
            this.new_first_character_value.Visible = false;
            // 
            // new_second_character_value
            // 
            this.new_second_character_value.Location = new System.Drawing.Point(229, 339);
            this.new_second_character_value.Name = "new_second_character_value";
            this.new_second_character_value.Size = new System.Drawing.Size(136, 20);
            this.new_second_character_value.TabIndex = 21;
            this.new_second_character_value.Visible = false;
            // 
            // fir_choose_label
            // 
            this.fir_choose_label.AutoSize = true;
            this.fir_choose_label.Location = new System.Drawing.Point(9, 296);
            this.fir_choose_label.Name = "fir_choose_label";
            this.fir_choose_label.Size = new System.Drawing.Size(147, 13);
            this.fir_choose_label.TabIndex = 22;
            this.fir_choose_label.Text = "Choose characters to change";
            this.fir_choose_label.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 23;
            this.label5.Visible = false;
            // 
            // sec_choose_label
            // 
            this.sec_choose_label.AutoSize = true;
            this.sec_choose_label.Location = new System.Drawing.Point(226, 296);
            this.sec_choose_label.Name = "sec_choose_label";
            this.sec_choose_label.Size = new System.Drawing.Size(147, 13);
            this.sec_choose_label.TabIndex = 24;
            this.sec_choose_label.Text = "Choose characters to change";
            this.sec_choose_label.Visible = false;
            // 
            // change_btn
            // 
            this.change_btn.AutoSize = true;
            this.change_btn.Location = new System.Drawing.Point(117, 365);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(157, 23);
            this.change_btn.TabIndex = 25;
            this.change_btn.Text = "Change animals characters ";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Visible = false;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // start_battle
            // 
            this.start_battle.AutoSize = true;
            this.start_battle.Location = new System.Drawing.Point(69, 246);
            this.start_battle.Name = "start_battle";
            this.start_battle.Size = new System.Drawing.Size(256, 23);
            this.start_battle.TabIndex = 27;
            this.start_battle.Text = "Start battle";
            this.start_battle.UseVisualStyleBackColor = true;
            this.start_battle.Click += new System.EventHandler(this.start_battle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_battle);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.sec_choose_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fir_choose_label);
            this.Controls.Add(this.new_second_character_value);
            this.Controls.Add(this.new_first_character_value);
            this.Controls.Add(this.change_second_character);
            this.Controls.Add(this.change_first_character);
            this.Controls.Add(this.show_characters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.all_characteristics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_choose);
            this.Controls.Add(this.second_characters);
            this.Controls.Add(this.second_animal);
            this.Controls.Add(this.first_characters);
            this.Controls.Add(this.first_animal);
            this.Name = "Form1";
            this.Text = "Animal Battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_choose;
        private System.Windows.Forms.ListBox second_characters;
        private System.Windows.Forms.ComboBox second_animal;
        private System.Windows.Forms.ListBox first_characters;
        private System.Windows.Forms.ComboBox first_animal;
        private System.Windows.Forms.ListBox all_characteristics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button show_characters;
        private System.Windows.Forms.ComboBox change_second_character;
        private System.Windows.Forms.ComboBox change_first_character;
        private System.Windows.Forms.TextBox new_first_character_value;
        private System.Windows.Forms.TextBox new_second_character_value;
        private System.Windows.Forms.Label fir_choose_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sec_choose_label;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button start_battle;
    }
}

