﻿using CleanArchitectureTemplate.Core.Contracts.EntitiesValidators;
using CleanArchitectureTemplate.Core.Contracts.Logger;
using CleanArchitectureTemplate.Core.Contracts.Repositories;
using CleanArchitectureTemplate.Core.Contracts.UseCases.Cruds.FooCrudUseCases.Update;
using CleanArchitectureTemplate.Core.Entities;
using CleanArchitectureTemplate.Core.UseCases.Cruds.EntityCrudUseCases;

namespace CleanArchitectureTemplate.Core.UseCases.Cruds.FooCrudUseCases
{
    public class UpdateFooUseCase : UpdateEntityUseCase<Foo>, IUpdateFooUseCase
    {
        public UpdateFooUseCase(IFooRepository fooRepository, IFooValidator fooValidator, ICoreLogger coreLogger) : base(fooRepository, fooValidator, coreLogger)
        {
        }
    }
}
