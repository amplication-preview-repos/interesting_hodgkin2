using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ImageService.Infrastructure;

public class ImageServiceDbContext : IdentityDbContext<IdentityUser>
{
    public ImageServiceDbContext(DbContextOptions<ImageServiceDbContext> options)
        : base(options) { }
}
