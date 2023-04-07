using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graveyard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            JSON.GetJSONfile();
        }
        public void TreeView(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Name)
            {
                case "Узел2":
                    {
                        dataGridView1.Visible = true;
                        DataGridViewRow row1 = new DataGridViewRow();
                        dataGridView1.Rows.Clear();
                        DataGridViewCell obj = new DataGridViewTextBoxCell();
                        DataGridViewCell data = new DataGridViewTextBoxCell();
                        obj.Value = "Ритуальный магазин";
                        data.Value = JSON.rs.name;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                    }
                    break;
                case "Узел3":
                    {
                        dataGridView1.Visible = true;
                        DataGridViewRow row1 = new DataGridViewRow();
                        DataGridViewRow row2 = new DataGridViewRow();
                        DataGridViewRow row3 = new DataGridViewRow();
                        DataGridViewRow row4 = new DataGridViewRow();
                        DataGridViewRow row5 = new DataGridViewRow();
                        dataGridView1.Rows.Clear();
                        DataGridViewCell obj = new DataGridViewTextBoxCell();
                        DataGridViewCell data = new DataGridViewTextBoxCell();
                        obj.Value = "Часовня";
                        data.Value = JSON.ch.name;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Цена за 1 свечу";
                        data1.Value = JSON.ch.price1Candle;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "Цена за 3 свечи";
                        data2.Value = JSON.ch.price3Candle;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Цена за 5 свечей";
                        data3.Value = JSON.ch.price5Candle;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Цена отпевания";
                        data4.Value = JSON.ch.funeral;
                        row5.Cells.AddRange(obj4, data4);
                        dataGridView1.Rows.Add(row5);
                    }
                    break;
                case "Узел5":
                    {
                        dataGridView1.Visible = true;
                        DataGridViewRow row1 = new DataGridViewRow();
                        DataGridViewRow row2 = new DataGridViewRow();
                        DataGridViewRow row3 = new DataGridViewRow();
                        DataGridViewRow row4 = new DataGridViewRow();
                        DataGridViewRow row5 = new DataGridViewRow();
                        dataGridView1.Rows.Clear();
                        DataGridViewCell obj = new DataGridViewTextBoxCell();
                        DataGridViewCell data = new DataGridViewTextBoxCell();
                        obj.Value = "Гробы";
                        data.Value = "Размер" + JSON.c.size;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Цена за сосну";
                        data1.Value = JSON.c.price_pine;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "Цена за лиственницу";
                        data2.Value = JSON.c.price_larch;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Цена за липу";
                        data3.Value = JSON.c.price_linden;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Цена за дуб";
                        data4.Value = JSON.c.price_oak;
                        row5.Cells.AddRange(obj4, data4);
                        dataGridView1.Rows.Add(row5);
                    }
                    break;
                case "Узел6":
                    {
                        dataGridView1.Visible = true;
                        DataGridViewRow row1 = new DataGridViewRow();
                        DataGridViewRow row2 = new DataGridViewRow();
                        DataGridViewRow row3 = new DataGridViewRow();
                        DataGridViewRow row4 = new DataGridViewRow();
                        DataGridViewRow row5 = new DataGridViewRow();
                        DataGridViewRow row6 = new DataGridViewRow();
                        dataGridView1.Rows.Clear();
                        DataGridViewCell obj = new DataGridViewTextBoxCell();
                        DataGridViewCell data = new DataGridViewTextBoxCell();
                        obj.Value = "Венки";
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Цена за белые лилии";
                        data1.Value = JSON.w.whiteLily;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "Цена за красные ррозы";
                        data2.Value = JSON.w.redRoses;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Цена за красные гвоздики";
                        data3.Value = JSON.w.redCarnation;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Цена за 2 искусственных цветка";
                        data4.Value = JSON.w.artifical2;
                        row5.Cells.AddRange(obj4, data4);
                        dataGridView1.Rows.Add(row5);
                        DataGridViewCell obj5 = new DataGridViewTextBoxCell();
                        DataGridViewCell data5 = new DataGridViewTextBoxCell();
                        obj5.Value = "Цена за 6 искусственных цветов";
                        data5.Value = JSON.w.artifical6;
                        row6.Cells.AddRange(obj5, data5);
                        dataGridView1.Rows.Add(row6);
                    }
                    break;
                case "Узел1":
                    {
                        dataGridView1.Visible = true;
                        DataGridViewRow row1 = new DataGridViewRow();
                        DataGridViewRow row2 = new DataGridViewRow();
                        DataGridViewRow row3 = new DataGridViewRow();
                        DataGridViewRow row4 = new DataGridViewRow();
                        DataGridViewRow row5 = new DataGridViewRow();
                        dataGridView1.Rows.Clear();
                        DataGridViewCell obj = new DataGridViewTextBoxCell();
                        DataGridViewCell data = new DataGridViewTextBoxCell();
                        obj.Value = "Могила";
                        data.Value = "Номер №" + JSON.g.number;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Уровень загрязнения";
                        data1.Value = JSON.g.pollutionlevel;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "ФИО умершего";
                        data2.Value = JSON.g.name;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Годы жизни";
                        data3.Value = JSON.g.life_years;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Текст";
                        data4.Value = JSON.g.text;
                        row5.Cells.AddRange(obj4, data4);
                        dataGridView1.Rows.Add(row5);
                    }
                    break;
            }
        }
    }
}
