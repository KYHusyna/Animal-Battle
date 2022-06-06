using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Animal_Battle
{
    public partial class Form1 : Form
    {
        string first_data,
            second_data;
        int damage = 0,
            resistance = 0,
            luck;

        string[] base_characters = new string[] { "Kind animal: ", "Power:", "Endurance:", "Health:",
            "Speed:", "Weight:", "Size:", "Weapon:" };
        string[] mammals_characters = new string[] { "Tooth size:","Leather thickness:" };
        string[] birds_characters = new string[] { "Claws length:" };
        string[] water_beast_characters = new string[] {"Mouth size:", "Shell stength:"};

        Random rand = new Random();//random characters

        private void show_characters_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "All characters";
            all_characteristics.Visible = true;
            all_characteristics.Items.Clear();

            all_characteristics.Items.Add("General characters");//add base characters
            foreach (string el in base_characters)
                all_characteristics.Items.Add(el);
            all_characteristics.Items.Add("");

            all_characteristics.Items.Add("Mammals characters");//add mammals characters
            foreach (string el in mammals_characters)
                all_characteristics.Items.Add(el);
            all_characteristics.Items.Add("");

            all_characteristics.Items.Add("Birds characters");//add birds characters 
            foreach (string el in birds_characters)
                all_characteristics.Items.Add(el);
            all_characteristics.Items.Add("");

            all_characteristics.Items.Add("Water beast characters");// add water beast characters
            foreach (string el in water_beast_characters)
                all_characteristics.Items.Add(el);
        }


        public Form1()
        {
            InitializeComponent();

            //selections animal in first combobox
            first_animal.Items.Add("Sabretooth tiger");
            first_animal.Items.Add("Eagle");
            first_animal.Items.Add("Crocodile");
            //selections animal in second combobox
            second_animal.Items.Add("Sabretooth tiger");
            second_animal.Items.Add("Eagle");
            second_animal.Items.Add("Crocodile");

        }


        private void start_battle_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            all_characteristics.Visible = true;

            int first_animal_damage=0,
                second_animal_damage=0,
                first_animal_resistance=0,
                second_animal_resistance=0,
                first_animal_health=0,
                second_animal_health=0,
                first_attack=rand.Next(1,3);

            using (StreamWriter outputFile = new StreamWriter("D:/Lessons/3cours_first_semester/OOP Cource project/Animal Battle/Animal Battle/bin/First_animal_characters.txt"))
            {
                foreach (string line in first_characters.Items)
                    outputFile.WriteLine(line);
            }

            using (StreamWriter outputFile = new StreamWriter("D:/Lessons/3cours_first_semester/OOP Cource project/Animal Battle/Animal Battle/bin/Second_animal_characters.txt"))
            {
                foreach (string line in second_characters.Items)
                    outputFile.WriteLine(line);
            }

            string character;
           
            if (first_animal.Text != "" && second_animal.Text != "")
            {
                label3.Text = "Battle history";
                all_characteristics.Items.Clear();
                all_characteristics.Items.Add(first_animal.Text + " VS " + second_animal.Text);

                if (first_characters.Items.Count != 0 && second_characters.Items.Count != 0)
                {
                    if (first_attack == 1)
                     all_characteristics.Items.Add("First attack from 1st animal: " + first_animal.Text);
                    else
                        all_characteristics.Items.Add("First attack from 2nd animal: " + second_animal.Text);
                }
                else
                MessageBox.Show("Confirm your choose");

            }
            else
                MessageBox.Show("Choose your animal");

                using (StreamReader sr = new StreamReader("D:/Lessons/3cours_first_semester/OOP Cource project/Animal Battle/Animal Battle/bin/First_animal_characters.txt", System.Text.Encoding.Default))
                {
                    while ((character = sr.ReadLine()) != null)//read from file all elements
                    {

                        if (character.Split(':')[0] == "Damage")//find important elements and write in variable
                            first_animal_damage = Convert.ToInt32(character.Split(':')[1]);

                        else if (character.Split(':')[0] == "Resistance")
                            first_animal_resistance = Convert.ToInt32(character.Split(':')[1]);

                        else if (character.Split(':')[0] == "Health")
                            first_animal_health = Convert.ToInt32(character.Split(':')[1]);
                    }
                }
                
            for (int i = 0; i < second_characters.Items.Count; i++)
            {
                using (StreamReader sr = new StreamReader("D:/Lessons/3cours_first_semester/OOP Cource project/Animal Battle/Animal Battle/bin/Second_animal_characters.txt", System.Text.Encoding.Default))
                {
                    while ((character = sr.ReadLine()) != null)
                    {
                        if (character.Split(':')[0] == "Damage")
                            second_animal_damage = Convert.ToInt32(character.Split(':')[1]);

                        else if (character.Split(':')[0] == "Resistance")
                            second_animal_resistance = Convert.ToInt32(character.Split(':')[1]);

                        else if (character.Split(':')[0] == "Health")
                            second_animal_health = Convert.ToInt32(character.Split(':')[1]);
                    }
                }
            }

            while (first_animal_health > 0 && second_animal_health > 0)
            {//fight algorithm, while 1 animal dont dead
                int Current_damage;
                luck = rand.Next(1,3);
                if (first_attack == 1)//luck
                {
                    if (luck == 1)// chance to hit 50/50
                    {
                        if (first_animal_damage < second_animal_resistance)
                            Current_damage = (second_animal_resistance - first_animal_damage) + rand.Next(1, 5);
                        else
                            Current_damage = (first_animal_damage / second_animal_resistance) + rand.Next(1, 5);

                        all_characteristics.Items.Add(first_animal.Text + " hit:" + Current_damage + " damage" );
                        second_animal_health -= Current_damage;
                    }
                    else
                    all_characteristics.Items.Add(first_animal.Text + " miss");

                    all_characteristics.Items.Add(second_animal.Text + " Health: " +second_animal_health);
                   all_characteristics.Items.Add("");
                    first_attack++;
                }
                else
                {
                    if (luck == 1)
                    {
                        if (second_animal_damage < first_animal_resistance)
                        Current_damage = (first_animal_resistance-second_animal_damage) + rand.Next(1, 5);
                    else
                        Current_damage = (second_animal_damage / first_animal_resistance) + rand.Next(1, 5);
;
                        all_characteristics.Items.Add(second_animal.Text + " hit with " + Current_damage + " damage");
                        first_animal_health -= Current_damage;
                    }

                    else
                    all_characteristics.Items.Add(first_animal.Text + " miss");

                    all_characteristics.Items.Add(first_animal.Text + " Health: " + first_animal_health);
                    all_characteristics.Items.Add("");

                    first_attack++;
                    first_attack = 1; ;
                }
                if(first_animal_health > 0 && second_animal_health <= 0)
                all_characteristics.Items.Add("first* "+first_animal.Text+" - Winner");

                else if (first_animal_health <= 0 && second_animal_health > 0)
                all_characteristics.Items.Add("second* " + second_animal.Text + " - Winner");

            }
        }
            

            private void change_btn_Click(object sender, EventArgs e)
        {
            first_data = change_first_character.Text;
            second_data = change_second_character.Text;

            if (first_data == "" && second_data == "")
                MessageBox.Show("Please choose characters to change");

            for(int i=0; i<first_characters.Items.Count; i++)
            {
                if (new_first_character_value.Text != null)
                {
                    if (Convert.ToString(first_characters.Items[i]).Split(':')[0] == first_data)
                        first_characters.Items[i] = first_data + ":" + new_first_character_value.Text;
                }
            }

            for (int i = 0; i < second_characters.Items.Count; i++)
            {
                if (Convert.ToString(second_characters.Items[i]).Split(':')[0] == second_data)
                    second_characters.Items[i] = second_data + ":" + new_second_character_value.Text;
            }
        } 

        private void confirm_choose_Click(object sender, EventArgs e)
        {

            first_data = first_animal.Text;//check choose animal
            second_data = second_animal.Text;

            string move = "";

             luck = rand.Next(1,5);

            if (first_data == "" || second_data == "")
                MessageBox.Show("Please choose your animal");
            else
            {
                //change animals characters
                first_characters.Items.Clear(); second_characters.Items.Clear();
                foreach (string el in base_characters)
                {
                    first_characters.Items.Add(el);
                    second_characters.Items.Add(el);
                }

                int[] power_array = new int[] { };
                int[] health_array = new int[] { };
                string[] all_elements = new string[] { };


                switch (first_data)// for first list box
                {
                    case "Sabretooth tiger":  //for mammals
                        foreach (string el in mammals_characters)
                            first_characters.Items.Add(el);

                        Mammals mammals = new Mammals("", rand.Next(3, 15), rand.Next(3, 15), 
                            rand.Next(3, 25), rand.Next(3, 45), rand.Next(10, 35), rand.Next(3, 20),
                             "", rand.Next(3, 15), rand.Next(1, 8), ref power_array, ref health_array, ref all_elements);

                        for (int i = 0; i < all_elements.Length; i++)
                            first_characters.Items[i] += all_elements[i];

                        luck = rand.Next(1, 5);
                        damage = mammals.Count_damage(damage, power_array, luck);
                        first_characters.Items.Add("Damage:" + damage);

                        luck = rand.Next(1,5);
                        resistance = mammals.Count_resistance(resistance, health_array, luck);
                        first_characters.Items.Add("Resistance:" + resistance );

                        move = mammals.Move(move);
                        first_characters.Items.Add("Move:"+move);
                        break;

                    case "Eagle": //for birds
                        foreach (string el in birds_characters)
                            first_characters.Items.Add(el);

                        Birds birds = new Birds("", rand.Next(3, 15), rand.Next(3, 15),
                            rand.Next(3, 45), rand.Next(3, 35), rand.Next(10, 45), rand.Next(3, 20),
                             "", rand.Next(3, 15), ref power_array, ref health_array, ref all_elements);

                        for (int i = 0; i < all_elements.Length; i++)
                            first_characters.Items[i] += all_elements[i];

                        luck = rand.Next(1, 5);
                        damage = birds.Count_damage(damage, power_array, luck);
                        first_characters.Items.Add("Damage:" + damage);

                        luck = rand.Next(1, 5);
                        resistance = birds.Count_resistance(resistance, health_array, luck);
                        first_characters.Items.Add("Resistance:" + resistance);

                        move = birds.Move(move);
                        first_characters.Items.Add("Move:" + move);
                        break;

                    case "Crocodile"://for water beast
                        foreach (string el in water_beast_characters)
                            first_characters.Items.Add(el);

                        Water_beast water_beast = new Water_beast("", rand.Next(3, 15), rand.Next(3, 15),
                            rand.Next(3, 25), rand.Next(3, 35), rand.Next(10, 45), rand.Next(3, 20),
                             "", rand.Next(3, 15), rand.Next(1, 8), ref power_array, ref health_array, ref all_elements);

                        for (int i = 0; i < all_elements.Length; i++)
                            first_characters.Items[i] += all_elements[i];

                        luck = rand.Next(1, 5);
                        damage = water_beast.Count_damage(damage, power_array, luck);
                        first_characters.Items.Add("Damage:" + damage);

                        luck = rand.Next(1, 5);
                        resistance = water_beast.Count_resistance(resistance, health_array, luck);
                        first_characters.Items.Add("Resistance:" + resistance);

                        move = water_beast.Move(move);
                        first_characters.Items.Add("Move:" + move);
                        break;

                    default:
                        second_animal.Text = "";
                        MessageBox.Show("Please choose your animal");
                        break;
                }
                damage = 0;
                resistance = 0;

                switch (second_data)//for second list box
                {
                    case "Sabretooth tiger":
                        foreach (string el in mammals_characters)
                            second_characters.Items.Add(el);

                        Mammals mammals = new Mammals("", rand.Next(3, 15), rand.Next(3, 15),
                            rand.Next(3, 25), rand.Next(3, 35), rand.Next(10, 45), rand.Next(3, 20),
                             "", rand.Next(3, 15), rand.Next(1, 8), ref power_array, ref health_array, ref all_elements);

                        for (int i = 0; i < all_elements.Length; i++)
                            second_characters.Items[i] += all_elements[i];

                        luck = rand.Next(1, 5);
                        damage = mammals.Count_damage(damage, power_array, luck);
                        second_characters.Items.Add("Damage:" + damage);

                        luck = rand.Next(1, 5);
                        resistance = mammals.Count_resistance(resistance, health_array, luck);
                        second_characters.Items.Add("Resistance:" + resistance);

                        move = mammals.Move(move);
                        second_characters.Items.Add("Move:" + move);
                        break;

                    case "Eagle":
                        foreach (string el in birds_characters)
                            second_characters.Items.Add(el);

                        Birds birds = new Birds("", rand.Next(3, 15), rand.Next(3, 15),
                            rand.Next(3, 25), rand.Next(3, 35), rand.Next(3, 15), rand.Next(3, 20),
                             "", rand.Next(3, 15), ref power_array, ref health_array, ref all_elements);

                        for (int i = 0; i < all_elements.Length; i++)
                            second_characters.Items[i] += all_elements[i];

                        luck = rand.Next(1, 5);
                        damage = birds.Count_damage(damage, power_array, luck);
                        second_characters.Items.Add("Damage:" + damage);

                        luck = rand.Next(1, 5);
                        resistance = birds.Count_resistance(resistance, health_array, luck);
                        second_characters.Items.Add("Resistance:" + resistance);

                        move = birds.Move(move);
                        second_characters.Items.Add("Move:" + move);
                        break;

                    case "Crocodile":
                        foreach (string el in water_beast_characters)
                            second_characters.Items.Add(el);

                        Water_beast water_beast = new Water_beast("", rand.Next(3, 15), rand.Next(3, 15),
                            rand.Next(3, 25), rand.Next(3, 35), rand.Next(10, 45), rand.Next(3, 20),
                              "", rand.Next(3, 15), rand.Next(1, 8), ref power_array, ref health_array, ref all_elements);

                        for (int i = 0; i < all_elements.Length; i++)
                            second_characters.Items[i] += all_elements[i];

                        luck = rand.Next(1, 5); 
                        damage = water_beast.Count_damage(damage, power_array, luck);
                        second_characters.Items.Add("Damage:" + damage);

                        luck = rand.Next(1, 5);
                        resistance = water_beast.Count_resistance(resistance, health_array, luck);
                        second_characters.Items.Add("Resistance:" + resistance);

                        move = water_beast.Move(move);
                        second_characters.Items.Add("Move:" + move);
                        break;

                    default:
                        first_animal.Text = "";
                        MessageBox.Show("Please choose your animal");
                        break;
                }

                change_first_character.Items.Clear();
                change_second_character.Items.Clear();

                foreach (Object el in first_characters.Items)//first characters to change
                {
                    first_data = Convert.ToString(el).Split(':')[0];
                    change_first_character.Items.Add(first_data);
                }

                foreach (Object el in second_characters.Items)//second characters to change
                {
                    second_data = Convert.ToString(el).Split(':')[0]; 
                    change_second_character.Items.Add(second_data); 
                }

                //make change interface visible
                fir_choose_label.Visible = true;
                sec_choose_label.Visible = true;
                change_first_character.Visible = true;
                change_second_character.Visible = true;
                new_first_character_value.Visible = true;
                new_second_character_value.Visible = true;
                change_btn.Visible = true;

            }
            damage = 0;
            resistance = 0;
        }
    }
    abstract class Animal
    {
        public string Kind_animal { get; set; }//1
        public int Power { get; set; }
        public int Endurance { get; set; }//3
        public int Health { get; set; }
        public int Speed { get; set; }//5
        public int Weight { get; set; }
        public int Size { get; set; }//7
        public string Weapon { get; set; }

        public Animal(string kind_animal, int power, int endurance, int health,
            int speed, int weight, int size, string weapon)
        {
            Kind_animal = kind_animal;
            Power = power;
            Endurance = endurance;
            Health = health;
            Speed = speed;
            Weight = weight;
            Size = size;
            Weapon = weapon;
        }

        public abstract int Count_damage(int damage, int[] power_elements, int luck);

        public abstract int Count_resistance(int resistance, int[] health_elements, int luck);

        public virtual string Move(string move)
        {
            move = "specific move";
            return move;
        }
    }

    class Mammals : Animal
    {
        public int tooth_size { get; set; }
        public int leather_thickness { get; set; }
        
        public Mammals(string kind_animal,  int power, int endurance, int health,
        int speed, int weight, int size, string weapon, int tooth_size, int leather_thickness, 
        ref int[] power_elements, ref int[] health_elements, ref string[] mammals_element)
            : base(kind_animal, power, endurance, health, speed, weight, size, weapon)
        {
            weapon = "Tooth";
            kind_animal = "Mammals";
            power_elements = new int[] { power, speed, weight, size, tooth_size };
            health_elements = new int[] { endurance, health, leather_thickness };
            mammals_element = new string[10];

            mammals_element[0] = kind_animal;
            mammals_element[1] = Convert.ToString(power);
            mammals_element[2] = Convert.ToString(endurance);
            mammals_element[3] = Convert.ToString(health);
            mammals_element[4] = Convert.ToString(speed);
            mammals_element[5] = Convert.ToString(weight);
            mammals_element[6] = Convert.ToString(size);
            mammals_element[7] = weapon;
            mammals_element[8] = Convert.ToString(tooth_size);
            mammals_element[9] = Convert.ToString(leather_thickness);
        }
        public override int Count_damage(int damage, int[] power_elements, int luck)
        {
            foreach(int el in power_elements)
                damage += el;
            return damage * luck;
        }
        public override int Count_resistance(int resistance, int[] health_elements, int luck)
        {
            foreach (int el in health_elements)
                resistance += el;
            return resistance * luck;
        }
        public override string Move(string move)
        {
            move = "Run,Walking";
            return move;
        }
    }

    class Birds : Animal
    {
        public int claws_length { get; set; }

        public Birds(string kind_animal, int power, int endurance, int health,
       int speed, int weight, int size, string weapon, int claws_length, ref int[] power_elements, 
       ref int[] health_elements, ref string[] bird_element)
           : base(kind_animal, power, endurance, health, speed, weight, size, weapon)
        {
            weapon = "Beak";
            kind_animal = "Birds";
            power_elements = new int[] { power, speed, weight, size, claws_length };
            health_elements = new int[] { endurance, health};
            bird_element = new string[9];

            bird_element[0] = kind_animal;
            bird_element[1] = Convert.ToString(power);
            bird_element[2] = Convert.ToString(endurance);
            bird_element[3] = Convert.ToString(health);
            bird_element[4] = Convert.ToString(speed);
            bird_element[5] = Convert.ToString(weight);
            bird_element[6] = Convert.ToString(size);
            bird_element[7] = weapon;
            bird_element[8] = Convert.ToString(claws_length);
        }
        public override int Count_damage(int damage, int[] power_elements, int luck)
        {
            foreach (int el in power_elements)
                damage += el;
            return damage * luck;
        }
        public override int Count_resistance(int resistance, int[] health_elements, int luck)
        {
            foreach (int el in health_elements)
                resistance += el;
            return resistance * luck;
        }
        public override string Move(string move)
        {
            move = "Flying";
            return move;
        }
    }

    class Water_beast : Animal
    {
        public int mouth_size { get; set; }
        public int shell_strength { get; set; }

        public Water_beast(string kind_animal, int power, int endurance, int health,
       int speed, int weight, int size, string weapon, int mouth_size, int shell_strength, 
       ref int[] power_elements, ref int[] health_elements, ref string[] water_beast_element)
           : base(kind_animal, power, endurance, health, speed, weight, size, weapon)
        {
            weapon = "Tooth";
            kind_animal = "Water beast";
            power_elements = new int[] { power, speed, weight, size, mouth_size };
            health_elements = new int[] { endurance, health, shell_strength };
            water_beast_element = new string[10];

            water_beast_element[0] = kind_animal;
            water_beast_element[1] = Convert.ToString(power);
            water_beast_element[2] = Convert.ToString(endurance);
            water_beast_element[3] = Convert.ToString(health);
            water_beast_element[4] = Convert.ToString(speed);
            water_beast_element[5] = Convert.ToString(weight);
            water_beast_element[6] = Convert.ToString(size);
            water_beast_element[7] = weapon;
            water_beast_element[8] = Convert.ToString(mouth_size);
            water_beast_element[9] = Convert.ToString(shell_strength);
        }

        public override int Count_damage(int damage, int[] power_elements, int luck)
        {
            foreach (int el in power_elements)
                damage += el;
            return damage * luck;
        }
        public override int Count_resistance(int resistance, int[] health_elements, int luck)
        {
            foreach (int el in health_elements)
                resistance += el;
            return resistance * luck;
        }
        public override string Move(string move)
        {
            move = "Swimming";
            return move;
        }
    }
}

