using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UserVehicleSection.Models.Identity;

namespace UserVehicleSection.Models
{
    public partial class UserSectionContext : DbContext
    {
        public UserSectionContext()
        {
        }

        public UserSectionContext(DbContextOptions<UserSectionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssignedTechDb> AssignedTechDb { get; set; }
        public virtual DbSet<MessageDb> MessageDb { get; set; }
        public virtual DbSet<ServiceReqDb> ServiceReqDb { get; set; }
        public virtual DbSet<ServicedHistDb> ServicedHistDb { get; set; }
        public virtual DbSet<ShopServicesDb> ShopServicesDb { get; set; }
        public virtual DbSet<ShopTechDb> ShopTechDb { get; set; }
        public virtual DbSet<UserDb> UserDb { get; set; }
        public virtual DbSet<UserImgDb> UserImgDb { get; set; }
        public virtual DbSet<UserVehDb> UserVehDb { get; set; }
        public virtual DbSet<VehReqDb> VehReqDb { get; set; }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L37PVF3;Initial Catalog=UserSection;Integrated Security=True");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignedTechDb>(entity =>
            {
                entity.HasKey(e => e.AssignId)
                    .HasName("PK__Assigned__9FFF4C4F8F2C83B9");

                entity.Property(e => e.AssignId).HasColumnName("AssignID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.AssignedTechDb)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__AssignedT__Servi__36B12243");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.AssignedTechDb)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK__AssignedT__Techn__35BCFE0A");
            });

            modelBuilder.Entity<MessageDb>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__MessageD__C87C037C19775158");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.MessageDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehReqId).HasColumnName("VehReqID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MessageDb)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__MessageDb__UserI__3A81B327");

                entity.HasOne(d => d.VehReq)
                    .WithMany(p => p.MessageDb)
                    .HasForeignKey(d => d.VehReqId)
                    .HasConstraintName("FK__MessageDb__VehRe__398D8EEE");
            });

            modelBuilder.Entity<ServiceReqDb>(entity =>
            {
                entity.HasKey(e => e.SerReqId)
                    .HasName("PK__ServiceR__371BFCBC4C3344E3");

                entity.Property(e => e.SerReqId).HasColumnName("SerReqID");

                entity.Property(e => e.AssignId).HasColumnName("AssignID");

                entity.Property(e => e.VehReqId).HasColumnName("VehReqID");

                entity.HasOne(d => d.Assign)
                    .WithMany(p => p.ServiceReqDb)
                    .HasForeignKey(d => d.AssignId)
                    .HasConstraintName("FK__ServiceRe__Assig__3E52440B");

                entity.HasOne(d => d.VehReq)
                    .WithMany(p => p.ServiceReqDb)
                    .HasForeignKey(d => d.VehReqId)
                    .HasConstraintName("FK__ServiceRe__VehRe__3D5E1FD2");
            });

            modelBuilder.Entity<ServicedHistDb>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK__Serviced__4D7B4ADD3653402F");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehReqId).HasColumnName("VehReqID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServicedHistDb)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__ServicedH__UserI__3C69FB99");

                entity.HasOne(d => d.VehReq)
                    .WithMany(p => p.ServicedHistDb)
                    .HasForeignKey(d => d.VehReqId)
                    .HasConstraintName("FK__ServicedH__VehRe__3B75D760");
            });

            modelBuilder.Entity<ShopServicesDb>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__ShopServ__C51BB0EAACCC9928");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceCost).HasColumnType("money");

                entity.Property(e => e.ServiceDescription).HasColumnType("text");

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShopServicesDb)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__ShopServi__UserI__37A5467C");
            });

            modelBuilder.Entity<ShopTechDb>(entity =>
            {
                entity.HasKey(e => e.TechnicianId)
                    .HasName("PK__ShopTech__301F82C1FE1CE5F1");

                entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");

                entity.Property(e => e.TechnicianDescription).HasColumnType("text");

                entity.Property(e => e.TechnicianName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShopTechDb)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__ShopTechD__UserI__38996AB5");
            });

            modelBuilder.Entity<UserDb>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserDb__1788CCAC2AD3AF85");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.UserAddress).HasMaxLength(50);

                entity.Property(e => e.UserCity).HasMaxLength(20);

                entity.Property(e => e.UserCountry).HasMaxLength(20);

                entity.Property(e => e.UserDescription).HasColumnType("text");

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasColumnType("text");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.UserDb)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK__UserDb__ImageID__4222D4EF");
            });

            modelBuilder.Entity<UserImgDb>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PK__UserImgD__7516F4EC98CF5A28");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");
            });

            modelBuilder.Entity<UserVehDb>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__UserVehD__476B54B2A588B996");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehicleMake).HasMaxLength(20);

                entity.Property(e => e.VehicleModel).HasMaxLength(20);

                entity.Property(e => e.VehicleVinNum).HasColumnType("ntext");

                entity.Property(e => e.VehicleYear).HasMaxLength(5);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVehDb)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserVehDb__UserI__3F466844");
            });

            modelBuilder.Entity<VehReqDb>(entity =>
            {
                entity.HasKey(e => e.VehReqId)
                    .HasName("PK__VehReqDb__DEC3D529094158CD");

                entity.Property(e => e.VehReqId).HasColumnName("VehReqID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehReqDate).HasColumnType("date");

                entity.Property(e => e.VehReqMessage).HasColumnType("text");

                entity.Property(e => e.VehReqName).HasMaxLength(50);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VehReqDb)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__VehReqDb__UserID__412EB0B6");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehReqDb)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK__VehReqDb__Vehicl__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
