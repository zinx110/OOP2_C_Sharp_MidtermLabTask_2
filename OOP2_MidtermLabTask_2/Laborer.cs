using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_2
{

class Laborer:Employee
{
	public int userRating;
	public static int chargePerServices=500;
	public int noOfServices;
	
	
	public Laborer()
	{
		Console.WriteLine("Laborer added");
	}
	
	public Laborer(string id, string name, string address, int rating, int service)
	{
		this.id=id;
		this.name=name;
		this.address=address;
		this.userRating=rating;
		this.noOfServices=service;
		
		Console.WriteLine("Laborer added");
	}
	
	public override void EmployeeStatus()
	{
		if(userRating>70 && noOfServices>=10)
		{
			Console.WriteLine("Eligible");
		}
		else
		{
			Console.WriteLine("Not eligible");
		}
	}
	
	
	public void totalEarn(int bonus)
	{
		Console.WriteLine("Total Earning: "+ ((chargePerServices*noOfServices)+bonus));
	}
	
	public override void ShowInfo()
	{
		
		Console.WriteLine("Employee Id: "+ id);
		Console.WriteLine("Employee name: "+ name);
		Console.WriteLine("Employee address: "+ address);
		Console.WriteLine("Employee userRating: "+ userRating);
		Console.WriteLine("Employee's charge: "+ chargePerServices);
		Console.WriteLine("Employee's total service: "+ noOfServices);
		
		EmployeeStatus();
		totalEarn(0);
		
	}
	
	public override bool isSkilledWorker()
	{
		if (userRating>80)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	
	
	
	
	
	
}

}
