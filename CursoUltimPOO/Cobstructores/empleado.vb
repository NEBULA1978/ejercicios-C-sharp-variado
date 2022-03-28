Public Class empleado
    Inherits Personas ' hereda de clase Alumno ,obtener todos los campos de clase Persona

    Public Overloads Sub Hablar() ' Overloads sobrescribe el metodo hablar de la clase padre
        Console.WriteLine("Estoy cansado de tanto estudiar")
    End Sub

End Class
