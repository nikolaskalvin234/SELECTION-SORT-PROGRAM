using System;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] umurMahasiswa = new int[10];

        // Input 10 umur mahasiswa
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Masukkan umur mahasiswa ke-{i + 1}: ");
            umurMahasiswa[i] = int.Parse(Console.ReadLine());
        }

        // Mengurutkan data umur mahasiswa
        Array.Sort(umurMahasiswa);

        // Menampilkan data umur mahasiswa yang sudah diurutkan
        Console.WriteLine("Data umur mahasiswa setelah diurutkan:");
        foreach (int umur in umurMahasiswa)
        {
            Console.WriteLine(umur);
        }
    }
}
}
