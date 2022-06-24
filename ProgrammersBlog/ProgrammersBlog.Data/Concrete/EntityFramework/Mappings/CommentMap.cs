using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");

            //builder.HasData(new Comment
            //{
            //    Id=1,
            //    ArticleId=1,
            //    Text= "Lorem Ipsum'un birçok pasaj varyasyonu mevcuttur, ancak çoğu, enjekte edilen mizah veya biraz inandırıcı görünmeyen rastgele kelimelerle bir şekilde değişikliğe uğramıştır. Lorem Ipsum'dan bir pasaj kullanacaksanız, metnin ortasında utanç verici bir şey olmadığından emin olmanız gerekir. İnternetteki tüm Lorem Ipsum oluşturucular, önceden tanımlanmış parçaları gerektiği gibi tekrarlama eğilimindedir ve bu da bunu İnternet'teki ilk gerçek oluşturucu yapar. Makul görünen Lorem Ipsum'u oluşturmak için bir avuç model cümle yapısıyla birleştirilmiş 200'den fazla Latince sözcükten oluşan bir sözlük kullanır. Üretilen Lorem Ipsum bu nedenle her zaman tekrardan, enjekte edilen mizahtan veya karakteristik olmayan kelimelerden vb.",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C# Makale Yorumu"
            //},new Comment
            //{
            //    Id = 2,
            //    ArticleId = 2,
            //    Text = "Lorem Ipsum'un birçok pasaj varyasyonu mevcuttur, ancak çoğu, enjekte edilen mizah veya biraz inandırıcı görünmeyen rastgele kelimelerle bir şekilde değişikliğe uğramıştır. Lorem Ipsum'dan bir pasaj kullanacaksanız, metnin ortasında utanç verici bir şey olmadığından emin olmanız gerekir. İnternetteki tüm Lorem Ipsum oluşturucular, önceden tanımlanmış parçaları gerektiği gibi tekrarlama eğilimindedir ve bu da bunu İnternet'teki ilk gerçek oluşturucu yapar. Makul görünen Lorem Ipsum'u oluşturmak için bir avuç model cümle yapısıyla birleştirilmiş 200'den fazla Latince sözcükten oluşan bir sözlük kullanır. Üretilen Lorem Ipsum bu nedenle her zaman tekrardan, enjekte edilen mizahtan veya karakteristik olmayan kelimelerden vb.",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C++ Makale Yorumu"
            //}
            //);
        }
    }
}
