using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_2
{

class Manager:Employee
{
	public int yearsOfExperience;
	
	
	
	
	
	public Manager()
	{
		Console.WriteLine("Manager added");
	}
	
	public Manager(string id, string name, string address,int exp)
	{
		this.id=id;
		this.name=name;
		this.address=address;
		this.yearsOfExperience=exp;
		Console.WriteLine("Manager added");
	}
	
	public override void EmployeeStatus()
	{
		if(yearsOfExperience>2)
		{
			Console.WriteLine("Eligible");
		}
		else
		{
			Console.WriteLine("Not eligible");
		}
	}
	
	
	public override void ShowInfo()
	{
		
		Console.WriteLine("Employee Id: "+ id);
		Console.WriteLine("Employee name: "+ name);
		Console.WriteLine("Employee address: "+ address);
		Console.WriteLine("Employee's years of experience : "+ yearsOfExperience);
		
		EmployeeStatus();
		
		
	}
	
}

}
