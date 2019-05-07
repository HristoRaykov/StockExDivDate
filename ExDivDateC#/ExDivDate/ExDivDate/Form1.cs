using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExDivDate
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void getDataButton_Click(object sender, EventArgs e)
        {            
            String[] tickersData = this.tickers.ToString().Trim().Split(' ');
            HtmlAgilityPack.HtmlDocument htmlDoc;
            String ticker;
            String exDivDate;
            String dividend;
            
            for (int i = 2; i < tickersData.Length; i++)
            {
                htmlDoc = GetHtmlDoc(tickersData[i]);
                ticker = tickersData[i];
                exDivDate = GetExDivDate(htmlDoc);
                dividend = GetDividendAmount(htmlDoc);
                String[] row = new String[3] { ticker, exDivDate, dividend };              

                this.stockGridView.Rows.Add(row);
            }

            tickers.Clear();

            
        }

        private static HtmlAgilityPack.HtmlDocument GetHtmlDoc(String ticker)
        {
            String url;

            if (ticker.Contains("-"))
            {
                url = "https://eresearch.fidelity.com/eresearch/evaluate/quote.jhtml?symbols="
                        + ticker.Split('-')[0] + "%2FP" + ticker.Split('-')[1];                
            }
            else if (ticker.Contains("p"))
            {                
                url = "https://eresearch.fidelity.com/eresearch/evaluate/quote.jhtml?symbols="
                        + ticker.Split('p')[0] + "%2FP" + ticker.Split('p')[1];
            }
            else
            {
                url = "https://screener.fidelity.com/ftgw/etf/goto/snapshot/quote.jhtml?symbols=" + ticker;
            }
            HtmlWeb web = new HtmlWeb();
            return web.Load(url);
        }

        private static String GetExDivDate(HtmlAgilityPack.HtmlDocument htmlDoc)
        {

            HtmlNode node = null;

            Boolean isPref = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Ex-Dividend Date']") != null;
            Boolean isFund = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Ex-Date ']") != null;

            if (isPref)
            {
                node = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Ex-Dividend Date']").NextSibling.NextSibling;
            }
            else if (isFund)
            {
                node = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Ex-Date ']").NextSibling.NextSibling;
            }

            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                return "No data";
            }
        }

        private static String GetDividendAmount(HtmlAgilityPack.HtmlDocument htmlDoc)
        {

            HtmlNode node = null;

            Boolean isPref = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Dividend']") != null;
            Boolean isFund = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Most Recent Distribution ']") != null;

            if (isPref)
            {
                node = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Dividend']").NextSibling.NextSibling;
            }
            else if (isFund)
            {
                node = htmlDoc.DocumentNode.SelectSingleNode("//th[text() ='Most Recent Distribution ']").NextSibling.NextSibling;
            }

            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                return "No data";
            }
        }

       
    }
}
