using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson 
        { 
            Id = id ,
            Name = "Teste", 
            Type = Communication.Enums.PetType.Dog,
            Birthday = new DateTime(year: 2018,month: 02, day: 27)
            
        };

    }
}
