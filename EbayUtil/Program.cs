using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace EbayUtil
{
	class Program
	{
		public static HtmlDocument doc;
		public static HtmlWeb web;
	
		public static string allCatsUrl = "http://www.ebay.co.uk/sch/allcategories/all-categories";
		public static List<string> catUrls;

		public static List<Item> sellers;

		//1
		public static void initializeVars()
		{
			doc = new HtmlDocument();
			web = new HtmlWeb();

			catUrls = new List<string>();

			sellers = new List<Item>();
		}

		//2
		public static void loadCategoriesPage()
		{
			doc = web.Load(allCatsUrl);
		}

		//3
		public static void loadCategoryUrls(string xpath)
		{
			List<HtmlNode> sellerNodes = new List<HtmlNode>();

			sellerNodes = doc.DocumentNode.SelectNodes(xpath).ToList<HtmlNode>();
		}

		//0
		static void Main(string[] args)
		{
			initializeVars();
			loadCategoriesPage();
			Console.Read();
		}
	}
}
