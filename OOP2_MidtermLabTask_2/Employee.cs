using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_2
{

class Employee
{
	public string id;
	public string name;
	public string address;
	public Employee ()
	{
		Console.WriteLine("Employee added");
	}
	
	public Employee (string id, string name, string address)
	{
		this.id=id;
		this.name=name;
		this.address=address;
		
		Console.WriteLine("Employee added");
	}
	
	public virtual void ShowInfo()
	{
		Console.WriteLine("Employee Id"+ id);
		Console.WriteLine("Employee Id"+ name);
		Console.WriteLine("Employee Id"+ address);
	}
	
	public virtual void EmployeeStatus()
	{
		Console.WriteLine("Not eligible");
		
	}
	public virtual bool isSkilledWorker()
	{
		return false;
	}
	
	 
	
	
	
	
	
}

}
