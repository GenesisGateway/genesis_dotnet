using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsDependenciesResolver
{
    class Program
    {
        static bool AreSame(HashSet<string> set, HashSet<string> otherSet)
        {
            if (set.Count != otherSet.Count)
            {
                return false;
            }

            foreach (var element in set)
            {
                if (!otherSet.Contains(element))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            var models = Requests.Models;

            var dict = new Dictionary<string, HashSet<string>>();
            foreach (var response in models)
            {
                var name = response.Item1;
                foreach (var field in response.Item2)
                {
                    if (!dict.ContainsKey(field))
                    {
                        dict.Add(field, new HashSet<string>());
                    }
                    dict[field].Add(name);
                }
            }

            HashSet<string> addedToGroup = new HashSet<string>();
            var groups = new List<List<string>>();
            foreach (string field in dict.Keys)
            {
                if (!addedToGroup.Contains(field))
                {
                    var newGroup = new List<string>();
                    newGroup.Add(field);

                    foreach (string otherField in dict.Keys)
                    {
                        if (field != otherField && !addedToGroup.Contains(otherField) && AreSame(dict[field], dict[otherField]))
                        {
                            newGroup.Add(otherField);
                            addedToGroup.Add(otherField);
                        }
                    }

                    groups.Add(newGroup);
                }
            }

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < groups.Count; i++)
            {
                output.Append(i + ": " + Environment.NewLine + "{ ");
                foreach (var field in groups[i])
                {
                    output.Append(field + ", ");
                }
                output.Append("}" + Environment.NewLine);
            }

            output.Append(Environment.NewLine);
            foreach (var response in models)
            {
                output.Append(response.Item1 + ": " + Environment.NewLine);
                for (int i = 0; i < groups.Count; i++)
                {
                    if (response.Item2.Contains(groups[i].First()))
                    {
                        output.Append(i + ", ");
                    }
                }
                output.Append(Environment.NewLine);
            }

            Console.WriteLine(output);
        }
    }
}