using System;
using System.ServiceModel;
using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Services
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class RegistrationService : IRegistrationContract
	{
		private readonly IGenericRepository<User> _repository;
		private readonly IMapper _mapper;

		public RegistrationService(IGenericRepository<User> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public bool Register(UserDTO user)
		{
			try
			{
				if (_repository.GetItem(x => x.Email == user.Email) == null)
				{
					_repository.Create(_mapper.Map<User>(user));
					return true;
				}

				return false;
			}
			catch (Exception e)
			{
				return false;
			}
		}
	}C:\Users\Andrew\source\repos\WahahaQ\KanbanBoard\DataAccessLayer\DataDiagram.edmx
}