﻿using DLL.Model;
using DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetAAsync(string email);
        Task<Student> InsertAsync(Student student);
        Task<Student> UpdateAsync(string email, Student student);
        Task<Student> DeleteAsync(string email);
    }
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> InsertAsync(Student student)
        {
            return await _studentRepository.InsertAsync(student);
        }
        public async Task<Student> GetAAsync(string email)
        {
            return await _studentRepository.GetAAsync(email);
        }
        public async Task<List<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllAsync();
        }
        public async Task<Student> UpdateAsync(string email, Student student)
        {
            return await _studentRepository.UpdateAsync(email, student);
        }
        public async Task<Student> DeleteAsync(string email)
        {
            return await _studentRepository.DeleteAsync(email);
        }
    }
}
