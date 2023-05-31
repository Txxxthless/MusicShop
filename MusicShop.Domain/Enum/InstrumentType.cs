
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Domain.Enum
{
    public enum InstrumentType
    {
        [Display(Name = "Keyboard")]
        Keyboard,
        [Display(Name = "String")]
        String,
        [Display(Name = "Percussion")]
        Percussion,
        [Display(Name = "Accessory")]
        Accessory
    }
}
