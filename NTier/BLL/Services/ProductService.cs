using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ProductService
    {
        ProductRepo repo;
        Mapper mapper;
        public ProductService(ProductRepo repo)
        {
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }

        public List<ProductDTO> Get()
        {
            var data = repo.Get();
            var res = mapper.Map<List<ProductDTO>>(data);
            return res;
        }
        public ProductDTO Get(int id)
        {
            var data = repo.Get(id);
            var res = mapper.Map<ProductDTO>(data);
            return res;
        }
        public bool Create(ProductDTO c)
        {
            var dataa = mapper.Map<Product>(c);
            var res = repo.Create(dataa);
            return res;
        }
        public bool Update(ProductDTO c)
        {
            var dataa = mapper.Map<Product>(c);
            var res = repo.Update(dataa);
            return res;

        }
        public bool Delete(int id)
        {

            return repo.Delete(id);

        }
    }
}
