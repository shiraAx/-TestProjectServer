using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class ChildService : IChildService
    {
      readonly  IChildRepository rep;
       readonly IMapper mapper;
        public ChildService(IChildRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ChildModel> Add(ChildModel model)
        {
            ChildModel c= new ChildModel(model.Id,model.ChildId,model.Name,model.BirthDate);
           
           return mapper.Map<ChildModel>(await rep.Add(mapper.Map<Child>(model)));
        }

        public async Task Delete(string key)
        {
           await rep.Delete(key);
        }

        public async Task<List<ChildModel>> GetAll()
        {
           return mapper.Map<List<ChildModel>>(await rep.GetAll()); 
        }

        public async Task<ChildModel> GetById(string key)
        {
            return mapper.Map<ChildModel>(await rep.GetById(key));
        }

        public async Task<ChildModel> Update(ChildModel model)
        {
            return mapper.Map<ChildModel>(await rep.Update(mapper.Map<Child>(model)));
        }
    }
}
