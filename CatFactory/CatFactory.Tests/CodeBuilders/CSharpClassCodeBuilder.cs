using System.Collections.Generic;
using CatFactory.CodeFactory;
using CatFactory.OOP;

namespace CatFactory.Tests.CodeBuilders
{
    public class CSharpClassCodeBuilder : CSharpCodeBuilder
    {
        public CSharpClassCodeBuilder()
        {
        }

        public new IClassDefinition ObjectDefinition { get; set; }

        public override string FileName
            => ObjectDefinition.Name;
        
        public override void Translating()
        {
            Lines = new List<ILine>();

            var start = string.IsNullOrEmpty(ObjectDefinition.Namespace) ? 0 : 1;

            Lines.Add(new CodeLine("{0}public class {1}", Indent(start), ObjectDefinition.Name));

            Lines.Add(new CodeLine("{"));

            foreach (var field in ObjectDefinition.Fields)
            {
                Lines.Add(new CodeLine("{0}private {1} {2};", Indent(start + 2), field.Type, field.Name));
                Lines.Add(new CodeLine());
            }

            foreach (var property in ObjectDefinition.Properties)
            {
                Lines.Add(new CodeLine("{0}public {1} {2} {{ get; set; }}", Indent(start + 1), property.Type, property.Name));
                Lines.Add(new CodeLine());
            }

            foreach (var method in ObjectDefinition.Methods)
            {
                Lines.Add(new CodeLine("{0}public {1} {2}()", Indent(start + 2), method.Type, method.Name));
                Lines.Add(new CodeLine("{0}{{", Indent(start + 2)));

                foreach (var line in method.Lines)
                {
                    Lines.Add(line);
                }

                Lines.Add(new CodeLine("{0}}}", Indent(start + 2)));
            }

            Lines.Add(new CodeLine("{0}}}", Indent(start)));
        }
    }
}
