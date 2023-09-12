using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CepaApp.API.Models
{
    public class Account
    {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserID {get; set;}
	public int CountryID {get; set;}
	public string UserName {get; set;}
	public string Email {get; set;}
	public byte[] PasswordHash {get; set;}
	public byte[] PasswordSalt {get; set;}
	public string FirstName {get; set;}
	public string LastName {get; set;}
	public string Introduction {get; set;}
	public string UserType {get; set;}
	public DateTime DateOfBirth {get; set;}
	public string Gender {get; set;}
	public Guid rowguid {get; set;}
    public DateTime Created { get; set; }
    public DateTime LastActive { get; set; }
    public DateTime ModifiedDate { get; set; }
    }
}