<<<<<<< HEAD
﻿
using Microsoft.AspNetCore.Http;
using MusicShop.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MusicShop.Domain.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter manufacturer!")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Enter model!")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Select type!")]
        public InstrumentType Type { get; set; }

        [Required(ErrorMessage = "Enter description!")]
        public string Description { get; set; }

        [AllowNull]
        public byte[]? Image { get; set; }

        [Required(ErrorMessage = "Enter price!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Choose an image!")]
        public IFormFile Avatar { get; set; }
    }
}
=======
﻿
using Microsoft.AspNetCore.Http;
using MusicShop.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MusicShop.Domain.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter manufacturer!")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Enter model!")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Select type!")]
        public InstrumentType Type { get; set; }

        [Required(ErrorMessage = "Enter description!")]
        public string Description { get; set; }

        [AllowNull]
        public byte[]? Image { get; set; }

        [Required(ErrorMessage = "Enter price!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Choose an image!")]
        public IFormFile Avatar { get; set; }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
