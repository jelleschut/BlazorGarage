using Domain.Interfaces;
using Domain.Models;
using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Services.Interfaces;
using Web.Utils;
using FluentValidation;

namespace Web.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;
        private X509Encryptor encryptor;
        private OwnerValidator validator;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
            encryptor = new X509Encryptor();
            validator = new OwnerValidator();
        }

        public async Task Add(Owner owner)
        {
            if (IsValid(owner))
            {
                await _ownerRepository.AddAsync(EncryptOwner(owner));
            }
        }

        public async Task<Owner> Find(int id)
        {
            return DecryptOwner(await _ownerRepository.FindAsync(id));
        }

        public async Task<IEnumerable<Owner>> GetAll()
        {
            IEnumerable<Owner> owners = await _ownerRepository.GetAllAsync();
            List<Owner> decryptedOwners = new List<Owner>();

            foreach (Owner owner in owners)
            {
                decryptedOwners.Add(DecryptOwner(owner));
            }

            return decryptedOwners;
        }

        public async Task Update(Owner owner)
        {
            if(IsValid(owner))
            {
                await _ownerRepository.UpdateAsync(EncryptOwner(owner));
            }
        }

        public Owner EncryptOwner(Owner owner)
        {
            Owner encryptedOwner = owner;
            if (owner.OwnerType == Domain.Enums.OwnerEnum.DRIVER)
            {
                encryptedOwner.Name = encryptor.Encrypt(owner.Name);
            }

            encryptedOwner.City = encryptor.Encrypt(owner.City);
            encryptedOwner.Street = encryptor.Encrypt(owner.Street);
            encryptedOwner.HouseNumber = encryptor.Encrypt(owner.HouseNumber);
            encryptedOwner.Zipcode = encryptor.Encrypt(owner.Zipcode);
            encryptedOwner.PhoneNumber = encryptor.Encrypt(owner.PhoneNumber);
            encryptedOwner.Email = encryptor.Encrypt(owner.Email);

            return encryptedOwner;
        }

        public Owner DecryptOwner(Owner owner)
        {
            if (owner.OwnerType == Domain.Enums.OwnerEnum.DRIVER)
            {
                owner.Name = encryptor.Decrypt(owner.Name);
            }

            owner.City = encryptor.Decrypt(owner.City);
            owner.Street = encryptor.Decrypt(owner.Street);
            owner.HouseNumber = encryptor.Decrypt(owner.HouseNumber);
            owner.Zipcode = encryptor.Decrypt(owner.Zipcode);
            owner.PhoneNumber = encryptor.Decrypt(owner.PhoneNumber);
            owner.Email = encryptor.Decrypt(owner.Email);

            return owner;
        }

        public bool IsValid(Owner owner)
        {
            return owner != null && validator.Validate(owner).IsValid;
        }
    }
}
