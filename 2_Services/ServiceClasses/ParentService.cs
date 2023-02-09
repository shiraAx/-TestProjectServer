using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class ParentService : IParentService
    {
        IParentRepository rep;
        IMapper mapper;
        public ParentService(IParentRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ParentModel> Add(ParentModel model)
        {
            ParentModel f=new ParentModel(model.Id,model.ParentId, model.FirstName, model.LastName, model.Children, model.GenderType, model.HMOType, model.BirthDate); 
           return mapper.Map<ParentModel>(await rep.Add(mapper.Map<Parent>(model)));
        }

        public async Task Delete(string key)
        {
             await rep.Delete(key);
        }

        public async Task<List<ParentModel>> GetAll()
        {
            return mapper.Map<List<ParentModel>>(await rep.GetAll());
        }

        public async Task<ParentModel> GetById(string key)
        {
           return  mapper.Map<ParentModel>(await rep.GetById(key));
        }

        public async Task<ParentModel> Update(ParentModel model)
        {
            return mapper.Map<ParentModel>(await rep.Update(mapper.Map<Parent>(model)));
        }
    }
}
