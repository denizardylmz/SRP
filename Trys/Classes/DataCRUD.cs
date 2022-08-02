using Microsoft.EntityFrameworkCore;
using Trys.Data;
using Trys.Interfaces;
using Trys.Models;

namespace Trys;



public class DataCrud : IDataCrud
{
    private EmployeesContext _context = new EmployeesContext();

    public void DataWrite(List<string[]> csvData)
    {
        List<Personal> personals = new List<Personal>();
        foreach (var line in csvData)
        {
            var personal = new Personal()
                { Name = line[1], Title = line[2], PhoneNumber = line[3] };
            personals.Add(personal);
        }
        _context.Personals.AddRange(personals);
        _context.SaveChanges();
    }
}

