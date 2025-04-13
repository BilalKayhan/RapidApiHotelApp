using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto;
public class RoomAddDto
{
    [Required(ErrorMessage = "Oda Numarası Boş Geçilemez")]
    public string? RoomNumber { get; set; }
    public string? RoomCoverImage { get; set; }

    [Required(ErrorMessage = "Oda Fiyatı Boş Geçilemez")]
    public int Price { get; set; }

    [Required(ErrorMessage = "Oda Başlığı Boş Geçilemez")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Oda Yatak Kapasitesi Boş Geçilemez")]
    public string? BedCount { get; set; }

    [Required(ErrorMessage = "Oda Banyo Sayısı Boş Geçilemez")]
    public string? BathCount { get; set; }
    public string? Wifi { get; set; }
    public string? Description { get; set; }
}
