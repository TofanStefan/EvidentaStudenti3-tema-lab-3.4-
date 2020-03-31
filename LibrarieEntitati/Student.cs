using System;
namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[][] note = new int[4][];
        

        // contructor implicit
        public Student()
        {
            for (int i = 0; i < 4; i++)
            {
                note[i] = new int[0];
            }
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
            for (int i = 0; i < 4; i++)
            {
                note[i] = new int[0];
            }
        }

        public void SetNote(string sirNote)
        {
            int index, an = 0;
            string [] s_note;
            s_note = sirNote.Split(',');
            string[] note_AN;
            foreach(var An in s_note)
            {
                index = -1;
                note_AN = An.Split(' ');
                foreach(var nota_int in note_AN)
                {
                    index++;
                    Array.Resize(ref note[an], note[an].Length + 1);
                    note[an][index] = Convert.ToInt32(nota_int);
                }
                an++;   
            }
        }
        public void SetNote_ONE_BY_ONE(int[] note, int n, int linie)
        {
            Array.Resize(ref this.note[linie], this.note[linie].Length + n);
            
            for (int i = 0; i < n; i++)
            {
                this.note[linie][i] = note[i];
            }


        }
        public string ConversieLaSir()
        {
            string NoteAN1 = "Nu exista (Nu ati apelat metoda **setNote**)";
            string NoteAN2 = "Nu exista (Nu ati apelat metoda **setNote**)";
            string NoteAN3 = "Nu exista (Nu ati apelat metoda **setNote**)";
            string NoteAN4 = "Nu exista (Nu ati apelat metoda **setNote**)";

            if (note[0] != null)
            { 
                NoteAN1 = string.Join(",", note[0]);
                NoteAN2 = string.Join(",", note[1]);
                NoteAN3 = string.Join(",", note[2]);
                NoteAN4 = string.Join(",", note[3]);
            }
            string s = string.Format("Studentul {0} are notele:.... An1..{1}....An2..{2}....An3..{3}...An4 {4} ", nume, NoteAN1,NoteAN2,NoteAN3,NoteAN4);

            return s;
        }

    }
}
