using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models;

public class UserInfo
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Lütfen Geçerli Bir İsim Giriniz.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Lütfen Geçerli Bir Telefon Numarası Giriniz.")]
    public string? Phone { get; set; }
   
    [Required(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz.")]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]

    public bool WillAttend { get; set; }
}