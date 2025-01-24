using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedModels.Interfaces;
using SharedModels.Models;

namespace DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UniversityDbContext _context;

    public UserRepository(UniversityDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(IUser user)
    {
        switch (user)
        {
            case Student student:
                await _context.Students.AddAsync(student);
                break;
            case Professor professor:
                await _context.Professors.AddAsync(professor);
                break;
            case Admin admin:
                await _context.Admins.AddAsync(admin);
                break;
        }
        await _context.SaveChangesAsync();
    }

    public async Task<IUser?> GetByIdAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null) return student;

        var professor = await _context.Professors.FindAsync(id);
        if (professor != null) return professor;

        var admin = await _context.Admins.FindAsync(id);
        return admin;
    }

    public async Task<IUser?> GetByEmailAsync(string email)
    {
        var student = await _context.Students.FirstOrDefaultAsync(s => s.Email == email);
        if (student != null) return student;

        var professor = await _context.Professors.FirstOrDefaultAsync(p => p.Email == email);
        if (professor != null) return professor;

        var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Email == email);
        return admin;
    }
}