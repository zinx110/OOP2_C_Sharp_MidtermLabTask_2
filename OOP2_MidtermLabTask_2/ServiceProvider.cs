using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_2
{

class ServiceProvider
{
	public static Employee[] list = new Employee[100];
	public static int count=0;
	
	public ServiceProvider()
	{
		Console.WriteLine("Service Provider Initiated.");
	}
	
	public static void Insert(Employee emp)
	{
		list[count]=emp;
		count++;
	}
	
	public static void ProvideDetails()
	{
		Console.WriteLine("Service Provider Showing all Employee details.");
		for(int i=0;i<count;i++)
		{
			list[i].ShowInfo();
		}
	}
	
	public static void SkilledWorder()
	{
		Console.WriteLine("Service Provider Showing all Skilled workers.");
		
		for(int i=0;i<count;i++)
		{
			if(list[i].isSkilledWorker()==true)
			{
				list[i].ShowInfo();
			}
			
		}
	}
	
	
	
	
}


}
