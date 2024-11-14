using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class FilePathOperationsTask
	{
		private readonly string filePath;

		public FilePathOperationsTask(string filePath)
		{
			this.filePath = filePath;
		}
		public string extension()
		{
			return filePath.Substring(filePath.LastIndexOf('.') + 1);
		}
		public string filename()
		{
			int start = filePath.LastIndexOf('/') + 1;
			int end = filePath.LastIndexOf('.');
			return filePath.Substring(start, end - start);
		}
		public string dirpath()
		{
			int end = filePath.LastIndexOf('/') + 1;
			return filePath.Substring(0, end);
		}
	}
}
//https://www.codewars.com/kata/5844e0890d3bedc5c5000e54/train/csharp