using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Graveyard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XML.GetXMLfile();
        }
        public void TreeView(object sender, EventArgs e)
        {
            switch(treeView1.SelectedNode.Name)
            {
                case "Узел2":
                    {
                        dataGridView1.Visible = true;
                        DataGridViewRow row1 = new DataGridViewRow();
                        dataGridView1.Rows.Clear();
                        DataGridViewCell obj = new DataGridViewTextBoxCell();
                        DataGridViewCell data = new DataGridViewTextBoxCell();
                        obj.Value = "Ритуальный магазин";
                        data.Value = XML.rs.name;
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
                        data.Value = XML.ch.name;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Цена за 1 свечу";
                        data1.Value=XML.ch.price1Candle;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "Цена за 3 свечи";
                        data2.Value = XML.ch.price3Candle;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Цена за 5 свечей";
                        data3.Value = XML.ch.price5Candle;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Цена отпевания";
                        data4.Value = XML.ch.funeral;
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
                        data.Value = "Размер"+ XML.c.size;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Цена за сосну";
                        data1.Value = XML.c.price_pine;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "Цена за лиственницу";
                        data2.Value = XML.c.price_larch;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Цена за липу";
                        data3.Value = XML.c.price_linden;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Цена за дуб";
                        data4.Value = XML.c.price_oak;
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
                        data1.Value = XML.w.whiteLily;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "Цена за красные ррозы";
                        data2.Value = XML.w.redRoses;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Цена за красные гвоздики";
                        data3.Value = XML.w.redCarnation;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Цена за 2 искусственных цветка";
                        data4.Value = XML.w.artifical2;
                        row5.Cells.AddRange(obj4, data4);
                        dataGridView1.Rows.Add(row5);
                        DataGridViewCell obj5 = new DataGridViewTextBoxCell();
                        DataGridViewCell data5 = new DataGridViewTextBoxCell();
                        obj5.Value = "Цена за 6 искусственных цветов";
                        data5.Value = XML.w.artifical6;
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
                        data.Value = "Номер №" + XML.g.number;
                        row1.Cells.AddRange(obj, data);
                        dataGridView1.Rows.Add(row1);
                        DataGridViewCell obj1 = new DataGridViewTextBoxCell();
                        DataGridViewCell data1 = new DataGridViewTextBoxCell();
                        obj1.Value = "Уровень загрязнения";
                        data1.Value = XML.g.pollutionlevel;
                        row2.Cells.AddRange(obj1, data1);
                        dataGridView1.Rows.Add(row2);
                        DataGridViewCell obj2 = new DataGridViewTextBoxCell();
                        DataGridViewCell data2 = new DataGridViewTextBoxCell();
                        obj2.Value = "ФИО умершего";
                        data2.Value = XML.g.name;
                        row3.Cells.AddRange(obj2, data2);
                        dataGridView1.Rows.Add(row3);
                        DataGridViewCell obj3 = new DataGridViewTextBoxCell();
                        DataGridViewCell data3 = new DataGridViewTextBoxCell();
                        obj3.Value = "Годы жизни";
                        data3.Value = XML.g.life_years;
                        row4.Cells.AddRange(obj3, data3);
                        dataGridView1.Rows.Add(row4);
                        DataGridViewCell obj4 = new DataGridViewTextBoxCell();
                        DataGridViewCell data4 = new DataGridViewTextBoxCell();
                        obj4.Value = "Текст";
                        data4.Value = XML.g.text;
                        row5.Cells.AddRange(obj4, data4);
                        dataGridView1.Rows.Add(row5);
                    }
                    break;
            }

        }
    }
}
