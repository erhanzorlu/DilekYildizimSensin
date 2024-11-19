using DilekYildizimSensin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DilekYildizimSensin.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var superadmin = new AppUser
            {
                Id = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
                UserName = "erhanzorlu",
                NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                PhoneNumber = "+905439999999",
                FirstName = "Erhan",
                LastName = "Zorlu",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "https://static.vecteezy.com/system/resources/previews/024/183/525/non_2x/avatar-of-a-man-portrait-of-a-young-guy-illustration-of-male-character-in-modern-color-style-vector.jpg",
                Age=25,
                Gender=Models.Enums.GenderEnum.Erkek,
                Score=520,
                
                
            };
            superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                UserName = "umutyasar",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+905439999988",
                FirstName = "Admin",
                LastName = "User",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "https://img.freepik.com/premium-photo/graphic-designer-digital-avatar-generative-ai_934475-9292.jpg",
                 Age = 30,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 123,
            };

            var user1 = new AppUser
            {
                Id = Guid.Parse("5BDF3B72-62AF-4D30-8BC8-0B6CF723AE57"),
                UserName = "ahmetyildiz",
                NormalizedUserName = "AHMETYILDIZ@GMAIL.COM",
                Email = "ahmetyildiz@gmail.com",
                NormalizedEmail = "AHMETYILDIZ@GMAIL.COM",
                PhoneNumber = "+905439999987",
                FirstName = "Ahmet",
                LastName = "Yildiz",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 22,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 320,

            };

            var user2 = new AppUser
            {
                Id = Guid.Parse("C9A80A3A-F3AF-439B-A4A3-985E65272A22"),
                UserName = "melisekinci",
                NormalizedUserName = "MELISEKINCI@GMAIL.COM",
                Email = "melisekinci@gmail.com",
                NormalizedEmail = "MELISEKINCI@GMAIL.COM",
                PhoneNumber = "+905439999986",
                FirstName = "Melis",
                LastName = "Ekinci",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 19,
                Gender = Models.Enums.GenderEnum.Kadın,
                Score = 450,
            };

            var user3 = new AppUser
            {
                Id = Guid.Parse("a5b6d3ea-7baa-49b8-808c-2d7d72f9c0d1"),
                UserName = "cemakyildiz",
                NormalizedUserName = "CEMAKYILDIZ@GMAIL.COM",
                Email = "cemakyildiz@gmail.com",
                NormalizedEmail = "CEMAKYILDIZ@GMAIL.COM",
                PhoneNumber = "+905439999985",
                FirstName = "Cem",
                LastName = "Akyildiz",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 35,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 30,
            };

            var user4 = new AppUser
            {
                Id = Guid.Parse("e48db928-a5fc-4a9c-b72e-6373a453c6c7"),
                UserName = "serdarkaya",
                NormalizedUserName = "SERDARKAYA@GMAIL.COM",
                Email = "serdarkaya@gmail.com",
                NormalizedEmail = "SERDARKAYA@GMAIL.COM",
                PhoneNumber = "+905439999984",
                FirstName = "Serdar",
                LastName = "Kaya",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                 Age = 23,
                Gender = Models.Enums.GenderEnum.Kadın,
                Score = 390,
            };

            var user5 = new AppUser
            {
                Id = Guid.Parse("99f21431-f75d-4b53-b0bc-c46a5a8db1a9"),
                UserName = "elifdemir",
                NormalizedUserName = "ELIFDEMIR@GMAIL.COM",
                Email = "elifdemir@gmail.com",
                NormalizedEmail = "ELIFDEMIR@GMAIL.COM",
                PhoneNumber = "+905439999983",
                FirstName = "Elif",
                LastName = "Demir",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 29,
                Gender = Models.Enums.GenderEnum.Kadın,
                Score = 340,
            };

            var user6 = new AppUser
            {
                Id = Guid.Parse("C60543D1-ED62-495B-AE86-7038FCCE59F1"),
                UserName = "ahmetyilmaz",
                NormalizedUserName = "AHMETYILMAZ@GMAIL.COM",
                Email = "ahmetyilmaz@gmail.com",
                NormalizedEmail = "AHMETYILMAZ@GMAIL.COM",
                PhoneNumber = "+905439999984",
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 35,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 420,
            };

            var user7 = new AppUser
            {
                Id = Guid.Parse("D2E3B435-8C7F-4905-BCDE-223344556677"),
                UserName = "aysegunes",
                NormalizedUserName = "AYSEGUNES@GMAIL.COM",
                Email = "aysegunes@gmail.com",
                NormalizedEmail = "AYSEGUNES@GMAIL.COM",
                PhoneNumber = "+905439999985",
                FirstName = "Ayşe",
                LastName = "Güneş",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Kadın,
                Score = 310,
            };

            var user8 = new AppUser
            {
                Id = Guid.Parse("8515F6A5-2F62-4CC9-A084-9AC934553CBC"),
                UserName = "mehmetcan",
                NormalizedUserName = "MEHMETCAN@GMAIL.COM",
                Email = "mehmetcan@gmail.com",
                NormalizedEmail = "MEHMETCAN@GMAIL.COM",
                PhoneNumber = "+905439999986",
                FirstName = "Mehmet",
                LastName = "Can",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 32,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 500,
            };

            var user9 = new AppUser
            {
                Id = Guid.Parse("71216B21-B5DD-417F-96D5-E6BEE5B33F6D"),
                UserName = "zeynepkara",
                NormalizedUserName = "ZEYNEPKARA@GMAIL.COM",
                Email = "zeynepkara@gmail.com",
                NormalizedEmail = "ZEYNEPKARA@GMAIL.COM",
                PhoneNumber = "+905439999987",
                FirstName = "Zeynep",
                LastName = "Kara",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadın,
                Score = 280,
            };

            var user10 = new AppUser
            {
                Id = Guid.Parse("8C01427B-4877-4513-B4BF-B5FA9093A279"),
                UserName = "mertturan",
                NormalizedUserName = "MERTTURAN@GMAIL.COM",
                Email = "mertturan@gmail.com",
                NormalizedEmail = "MERTTURAN@GMAIL.COM",
                PhoneNumber = "+905439999988",
                FirstName = "Mert",
                LastName = "Turan",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image",
                Age = 30,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 380,
            };


            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(superadmin, admin,user1, user2, user3, user4, user5,user6,user7,user8,user9,user10);

        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
