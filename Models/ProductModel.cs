﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeComputer.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên sản phẩm.")]
        public string Name { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả sản phẩm.")]
        public string Description { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập giá sản phẩm.")]
        public decimal Price { get; set; }

        public int BrandId { get; set; }
        public int CategoryId {  get; set; }
        public string Slug { get; set; }

        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }

        public string Image { set; get; }

    }
}
