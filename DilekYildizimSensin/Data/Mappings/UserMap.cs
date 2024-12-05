using DilekYildizimSensin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                UserName = "Admin",
                NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                PhoneNumber = "+905439999999",
                FirstName = "Admin",
                LastName = "Bey",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "https://static.vecteezy.com/system/resources/previews/024/183/525/non_2x/avatar-of-a-man-portrait-of-a-young-guy-illustration-of-male-character-in-modern-color-style-vector.jpg",
                Age = 25,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 520,


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
                Id = Guid.NewGuid(),
                NormalizedUserName = "RUKENYAVUZ@GMAIL.COM",
                Email = "ruken.yavuz@gmail.com",
                NormalizedEmail = "RUKENYAVUZ@GMAIL.COM",
                PhoneNumber = "+905439999901",
                FirstName = "Ruken",
                LastName = "Yavuz",
                UserName = "Ruken Yavuz",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image1",
                Age = 25,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user2 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "CEMAKSU@GMAIL.COM",
                Email = "cem.aksu@gmail.com",
                NormalizedEmail = "CEMAKSU@GMAIL.COM",
                PhoneNumber = "+905439999902",
                FirstName = "Cem",
                LastName = "Aksu",
                UserName = "Cem Aksu",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image2",
                Age = 22,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user3 = new AppUser
            {
                Id =Guid.NewGuid(),
                NormalizedUserName = "IREMKELES@GMAIL.COM",
                Email = "irem.keles@gmail.com",
                NormalizedEmail = "IREMKELES@GMAIL.COM",
                PhoneNumber = "+905439999903",
                FirstName = "İrem",
                LastName = "Keleş",
                UserName = "İrem Keleş",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image3",
                Age = 24,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user4 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "HAZALSERKAYA@GMAIL.COM",
                Email = "hazal.serkaya@gmail.com",
                NormalizedEmail = "HAZALSERKAYA@GMAIL.COM",
                PhoneNumber = "+905439999904",
                FirstName = "Hazal",
                LastName = "Serkaya",
                UserName = "Hazal Serkaya",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image4",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user5 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ZEYNEPSENACELIK@GMAIL.COM",
                Email = "zeynep.sena.celik@gmail.com",
                NormalizedEmail = "ZEYNEPSENACELIK@GMAIL.COM",
                PhoneNumber = "+905439999905",
                FirstName = "Zeynep Sena",
                LastName = "Çelik",
                UserName = "Zeynep Sena Çelik",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image5",
                Age = 23,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user6 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ALIÖZDEMIR@GMAIL.COM",
                Email = "ali.ozdemir@gmail.com",
                NormalizedEmail = "ALIÖZDEMIR@GMAIL.COM",
                PhoneNumber = "+905439999906",
                FirstName = "Ali",
                LastName = "Özdemir",
                UserName = "Ali Özdemir",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image6",
                Age = 30,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user7 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ERHANZORLU@GMAIL.COM",
                Email = "erhan.zorlu@gmail.com",
                NormalizedEmail = "ERHANZORLU@GMAIL.COM",
                PhoneNumber = "+905439999907",
                FirstName = "Erhan",
                LastName = "Zorlu",
                UserName = "Erhan Zorlu",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image7",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user8 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "YAĞMURAY@GMAIL.COM",
                Email = "yagmur.ay@gmail.com",
                NormalizedEmail = "YAĞMURAY@GMAIL.COM",
                PhoneNumber = "+905439999908",
                FirstName = "Yağmur",
                LastName = "Ay",
                UserName = "Yağmur Ay",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image8",
                Age = 21,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user9 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "NORAİPEKÇİ@GMAIL.COM",
                Email = "nora.ipekci@gmail.com",
                NormalizedEmail = "NORAİPEKÇİ@GMAIL.COM",
                PhoneNumber = "+905439999909",
                FirstName = "Nora",
                LastName = "İpekçi",
                UserName = "Nora İpekçi",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image9",
                Age = 24,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user10 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MELIKEÖZDIL@GMAIL.COM",
                Email = "melike.ozdil@gmail.com",
                NormalizedEmail = "MELIKEÖZDIL@GMAIL.COM",
                PhoneNumber = "+905439999910",
                FirstName = "Melike",
                LastName = "Özdil",
                UserName = "Melike Özdil",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image10",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };
            var user11 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ALPERGOKSELYILMAZ@GMAIL.COM",
                Email = "alper.goksel.yilmaz@gmail.com",
                NormalizedEmail = "ALPERGOKSELYILMAZ@GMAIL.COM",
                PhoneNumber = "+905439999911",
                FirstName = "Alper Göksel",
                LastName = "Yılmaz",
                UserName = "Alper Göksel Yılmaz",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image11",
                Age = 29,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user12 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "SALIHACANIGUR@GMAIL.COM",
                Email = "saliha.canigur@gmail.com",
                NormalizedEmail = "SALIHACANIGUR@GMAIL.COM",
                PhoneNumber = "+905439999912",
                FirstName = "Saliha",
                LastName = "Canıgür",
                UserName = "Saliha Canıgür",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image12",
                Age = 23,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user13 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "HUSEYINADAS@GMAIL.COM",
                Email = "huseyin.adas@gmail.com",
                NormalizedEmail = "HUSEYINADAS@GMAIL.COM",
                PhoneNumber = "+905439999913",
                FirstName = "Hüseyin",
                LastName = "Adaş",
                UserName = "Hüseyin Adaş",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image13",
                Age = 31,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user14 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "FERITERDEN@GMAIL.COM",
                Email = "ferit.erden@gmail.com",
                NormalizedEmail = "FERITERDEN@GMAIL.COM",
                PhoneNumber = "+905439999914",
                FirstName = "Ferit",
                LastName = "Erden",
                UserName = "Ferit Erden",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image14",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user15 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "NERGIS@GMAIL.COM",
                Email = "nergis@gmail.com",
                NormalizedEmail = "NERGIS@GMAIL.COM",
                PhoneNumber = "+905439999915",
                FirstName = "Nergis",
                LastName = "Gül",
                UserName = "Nergis Gül",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image15",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user16 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ILAYDACELEBI@GMAIL.COM",
                Email = "ilayda.celebi@gmail.com",
                NormalizedEmail = "ILAYDACELEBI@GMAIL.COM",
                PhoneNumber = "+905439999916",
                FirstName = "İlayda",
                LastName = "Çelebi",
                UserName = "İlayda Çelebi",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image16",
                Age = 24,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user17 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "GOKHANSHAHIN@GMAIL.COM",
                Email = "gokhan.sahin@gmail.com",
                NormalizedEmail = "GOKHANSHAHIN@GMAIL.COM",
                PhoneNumber = "+905439999917",
                FirstName = "Gökhan",
                LastName = "Şahin",
                UserName = "Gökhan Şahin",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image17",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user18 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "OZGEAKAR@GMAIL.COM",
                Email = "ozge.akar@gmail.com",
                NormalizedEmail = "OZGEAKAR@GMAIL.COM",
                PhoneNumber = "+905439999918",
                FirstName = "Özge",
                LastName = "Akar",
                UserName = "Özge Akar",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image18",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user19 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "IPEKGURDAMAR@GMAIL.COM",
                Email = "ipek.gurdamar@gmail.com",
                NormalizedEmail = "IPEKGURDAMAR@GMAIL.COM",
                PhoneNumber = "+905439999919",
                FirstName = "İpek",
                LastName = "Gürdamar",
                UserName = "İpek Gürdamar",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image19",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user20 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MELISAERTAN@GMAIL.COM",
                Email = "melisa.ertan@gmail.com",
                NormalizedEmail = "MELISAERTAN@GMAIL.COM",
                PhoneNumber = "+905439999920",
                FirstName = "Melisa",
                LastName = "Ertan",
                UserName = "Melisa Ertan",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image20",
                Age = 22,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };
            var user21 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ARMAGANYAGCI@GMAIL.COM",
                Email = "armagan.yagci@gmail.com",
                NormalizedEmail = "ARMAGANYAGCI@GMAIL.COM",
                PhoneNumber = "+905439999921",
                FirstName = "Armağan",
                LastName = "Yağcı",
                UserName = "Armağan Yağcı",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image21",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user22 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "FILIZCETINNARSAP@GMAIL.COM",
                Email = "filiz.cetin.narsap@gmail.com",
                NormalizedEmail = "FILIZCETINNARSAP@GMAIL.COM",
                PhoneNumber = "+905439999922",
                FirstName = "Filiz",
                LastName = "Çetin Narşap",
                UserName = "Filiz Çetin Narşap",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image22",
                Age = 30,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user23 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "HANDEREN@GMAIL.COM",
                Email = "hande.eren@gmail.com",
                NormalizedEmail = "HANDEREN@GMAIL.COM",
                PhoneNumber = "+905439999923",
                FirstName = "Hande",
                LastName = "Eren",
                UserName = "Hande Eren",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image23",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user24 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "NERGISAKTAS@GMAIL.COM",
                Email = "nergis.aktas@gmail.com",
                NormalizedEmail = "NERGISAKTAS@GMAIL.COM",
                PhoneNumber = "+905439999924",
                FirstName = "Nergis",
                LastName = "Aktaş",
                UserName = "Nergis Aktaş",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image24",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user25 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "GUNSUBERBER@GMAIL.COM",
                Email = "gunsu.berber@gmail.com",
                NormalizedEmail = "GUNSUBERBER@GMAIL.COM",
                PhoneNumber = "+905439999925",
                FirstName = "Günsu",
                LastName = "Berber",
                UserName = "Günsu Berber",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image25",
                Age = 29,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user26 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MELIKEOZDIL@GMAIL.COM",
                Email = "melike.ozdil@gmail.com",
                NormalizedEmail = "MELIKEOZDIL@GMAIL.COM",
                PhoneNumber = "+905439999926",
                FirstName = "Melike",
                LastName = "Özdil",
                UserName = "Melike Özdil",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image26",
                Age = 24,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user27 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "YASEMINKOCAMAN@GMAIL.COM",
                Email = "yasemin.kocaman@gmail.com",
                NormalizedEmail = "YASEMINKOCAMAN@GMAIL.COM",
                PhoneNumber = "+905439999927",
                FirstName = "Yasemin",
                LastName = "Kocaman",
                UserName = "Yasemin Kocaman",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image27",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };
            var user28 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "AYSENURCETIN@GMAIL.COM",
                Email = "aysenur.cetin@gmail.com",
                NormalizedEmail = "AYSENURCETIN@GMAIL.COM",
                PhoneNumber = "+905439999927",
                FirstName = "Ayşe Nur",
                LastName = "Çetin",
                UserName = "Ayşe Nur Çetin",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image27",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user29 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "SEYDAMUFTUOGLU@GMAIL.COM",
                Email = "seyda.muftuoglu@gmail.com",
                NormalizedEmail = "SEYDAMUFTUOGLU@GMAIL.COM",
                PhoneNumber = "+905439999929",
                FirstName = "Şeyda",
                LastName = "Müftüoğlu",
                UserName = "Şeyda Müftüoğlu",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image29",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user30 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "GOKSUGOKCESU@GMAIL.COM",
                Email = "goksu.gokcesu@gmail.com",
                NormalizedEmail = "GOKSUGOKCESU@GMAIL.COM",
                PhoneNumber = "+905439999930",
                FirstName = "Göksu",
                LastName = "Gökçesu",
                UserName = "Göksu Gökçesu",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image30",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user31 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "SEVVALVURAL@GMAIL.COM",
                Email = "sevval.vural@gmail.com",
                NormalizedEmail = "SEVVALVURAL@GMAIL.COM",
                PhoneNumber = "+905439999931",
                FirstName = "Şevval",
                LastName = "Vural",
                UserName = "Şevval Vural",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image31",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user32 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "RABIACANIGUR@GMAIL.COM",
                Email = "rabia.canigur@gmail.com",
                NormalizedEmail = "RABIACANIGUR@GMAIL.COM",
                PhoneNumber = "+905439999932",
                FirstName = "Rabia",
                LastName = "Canıgür",
                UserName = "Rabia Canıgür",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image32",
                Age = 25,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user33 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MELTEMERKMENKANDIL@GMAIL.COM",
                Email = "meltem.erkmen.kandil@gmail.com",
                NormalizedEmail = "MELTEMERKMENKANDIL@GMAIL.COM",
                PhoneNumber = "+905439999933",
                FirstName = "Meltem",
                LastName = "Erkmen Kandil",
                UserName = "Meltem Erkmen Kandil",
                PhoneNumberConfirmed = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image33",
                Age = 29,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user34 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "AHMETDENIZ@GMAIL.COM",
                Email = "ahmet.deniz@gmail.com",
                NormalizedEmail = "AHMETDENIZ@GMAIL.COM",
                PhoneNumber = "+905439999934",
                FirstName = "Ahmet",
                LastName = "Deniz",
                UserName = "Ahmet Deniz",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image34",
                Age = 30,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user35 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MUHSINCETINKAYA@GMAIL.COM",
                Email = "muhsin.cetinkaya@gmail.com",
                NormalizedEmail = "MUHSINCETINKAYA@GMAIL.COM",
                PhoneNumber = "+905439999935",
                FirstName = "Muhsin",
                LastName = "Çetinkaya",
                UserName = "Muhsin Çetinkaya",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image35",
                Age = 31,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user36 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "SULTANOZMERT@GMAIL.COM",
                Email = "sultan.ozmert@gmail.com",
                NormalizedEmail = "SULTANOZMERT@GMAIL.COM",
                PhoneNumber = "+905430000036",
                FirstName = "Sultan",
                LastName = "Özmert",
                UserName = "Sultan Özmert",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image36",
                Age = 25,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user37 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "AHMETALPOZDEMIR@GMAIL.COM",
                Email = "ahmet.alp.ozdemir@gmail.com",
                NormalizedEmail = "AHMETALPOZDEMIR@GMAIL.COM",
                PhoneNumber = "+905430000037",
                FirstName = "Ahmet Alp",
                LastName = "Özdemir",
                UserName = "Ahmet Alp Özdemir",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image37",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user38 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "EYLULEDACEKMENOGLU@GMAIL.COM",
                Email = "eylul.eda.cekmenoglu@gmail.com",
                NormalizedEmail = "EYLULEDACEKMENOGLU@GMAIL.COM",
                PhoneNumber = "+905430000038",
                FirstName = "Eylül Eda",
                LastName = "Çekmenoğlu",
                UserName = "Eylül Eda Çekmenoğlu",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image38",
                Age = 24,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user39 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "ZEYNEPCEMREORDU@GMAIL.COM",
                Email = "zeynep.cemre.ordu@gmail.com",
                NormalizedEmail = "ZEYNEPCEMREORDU@GMAIL.COM",
                PhoneNumber = "+905430000039",
                FirstName = "Zeynep Cemre",
                LastName = "Ordu",
                UserName = "Zeynep Cemre Ordu",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image39",
                Age = 26,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user40 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MIHRIBANAKDEMIR@GMAIL.COM",
                Email = "mihriban.akdemir@gmail.com",
                NormalizedEmail = "MIHRIBANAKDEMIR@GMAIL.COM",
                PhoneNumber = "+905430000040",
                FirstName = "Mihriban",
                LastName = "Akdemir",
                UserName = "Mihriban Akdemir",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image40",
                Age = 30,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user41 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "BUSEAYDEMIR@GMAIL.COM",
                Email = "buse.aydemir@gmail.com",
                NormalizedEmail = "BUSEAYDEMIR@GMAIL.COM",
                PhoneNumber = "+905430000041",
                FirstName = "Buse",
                LastName = "Aydemir",
                UserName = "Buse Aydemir",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image41",
                Age = 27,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user42 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "SEVVALNILSUTARHAN@GMAIL.COM",
                Email = "sevval.nilsu.tarhan@gmail.com",
                NormalizedEmail = "SEVVALNILSUTARHAN@GMAIL.COM",
                PhoneNumber = "+905430000042",
                FirstName = "Şevval Nilsu",
                LastName = "Tarhan",
                UserName = "Şevval Nilsu Tarhan",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image42",
                Age = 23,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user43 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "MELISAKIZILHISAR@GMAIL.COM",
                Email = "melisa.kizilhisar@gmail.com",
                NormalizedEmail = "MELISAKIZILHISAR@GMAIL.COM",
                PhoneNumber = "+905430000043",
                FirstName = "Melisa",
                LastName = "Kızılhisar",
                UserName = "Melisa Kızılhisar",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image43",
                Age = 29,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user44 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "BETULEMELBUTUNER@GMAIL.COM",
                Email = "betul.emel.butuner@gmail.com",
                NormalizedEmail = "BETULEMELBUTUNER@GMAIL.COM",
                PhoneNumber = "+905430000044",
                FirstName = "Betül Emel",
                LastName = "Bütüner",
                UserName = "Betül Emel Bütüner",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image44",
                Age = 31,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user45 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "BARISKELES@GMAIL.COM",
                Email = "baris.keles@gmail.com",
                NormalizedEmail = "BARISKELES@GMAIL.COM",
                PhoneNumber = "+905430000045",
                FirstName = "Barış",
                LastName = "Keleş",
                UserName = "Barış Keleş",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image45",
                Age = 32,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user46 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "LARADINC@GMAIL.COM",
                Email = "lara.dinc@gmail.com",
                NormalizedEmail = "LARADINC@GMAIL.COM",
                PhoneNumber = "+905430000046",
                FirstName = "Lara",
                LastName = "Dinç",
                UserName = "Lara Dinç",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image46",
                Age = 21,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user47 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "BUSRASELIMOGLU@GMAIL.COM",
                Email = "busra.selimoglu@gmail.com",
                NormalizedEmail = "BUSRASELIMOGLU@GMAIL.COM",
                PhoneNumber = "+905430000047",
                FirstName = "Büşra",
                LastName = "Selimoğlu",
                UserName = "Büşra Selimoğlu",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image47",
                Age = 28,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };

            var user48 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "DOGAMERT@GMAIL.COM",
                Email = "doga.mert@gmail.com",
                NormalizedEmail = "DOGAMERT@GMAIL.COM",
                PhoneNumber = "+905430000048",
                FirstName = "Doğa",
                LastName = "Mert",
                UserName = "Doğa Mert",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image48",
                Age = 24,
                Gender = Models.Enums.GenderEnum.Erkek,
                Score = 0,
            };

            var user49 = new AppUser
            {
                Id = Guid.NewGuid(),
                NormalizedUserName = "YARENTURGUT@GMAIL.COM",
                Email = "yaren.turgut@gmail.com",
                NormalizedEmail = "YARENTURGUT@GMAIL.COM",
                PhoneNumber = "+905430000049",
                FirstName = "Yaren",
                LastName = "Turgut",
                UserName = "Yaren Turgut",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageUrl = "image49",
                Age = 22,
                Gender = Models.Enums.GenderEnum.Kadin,
                Score = 0,
            };


            // Diğer kullanıcılar için de aynı şablonu devam ettirebilirim. Eksik veya ek bilgi varsa belirtmekten çekinme!






            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(
                superadmin,
                admin,
                user1,
                user2,
                user3,
                user4,
                user5,
                user6,
                user7,
                user8,
                user9,
                user10,
                user11,
                user12,
                user13,
                user14,
                user15,
                user16,
                user17,
                user18,
                user19,
                user20,
                user21,
                user22,
                user23,
                user24,
                user25,
                user26,
                user27,
                user28,
                user29,
                user30,
                user31,
                user32,
                user33,
                user34,
                user35,
                user36,
                user37,
                user38,
                user39,
                user40,
                user41,
                user42,
                user43,
                user44,
                user45,
                user46,
                user47,
                user48,
                user49



            );


        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
