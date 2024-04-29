using NUnit.Framework;
using AssemblyBrowserLibrary;
using AssemblyBrowserLibrary.AssemblyComposition;

namespace Tests
{
    [TestFixture]
    public class TestAssemblyBrowser
    {
        private AssemblyBrowser _assemblyBrowser;

        [SetUp]
        public void Setup()
        {
            // ������� ���� � �������� ������
            string assemblyPath = "D:\\FY\\SPP-L3\\AssemblyBrowserLibrary\\bin\\Debug\\net6.0\\AssemblyBrowserLibrary.dll";
            _assemblyBrowser = new AssemblyBrowser(assemblyPath);
        }

        [Test]
        public void LoadAssemblyFromFile_Success()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �� ����� null, ��� ��������� �� �������� �������� ������
            Assert.IsNotNull(assemblyInfo.Namespaces);
        }
        [Test]
        public void AssemblyInfoContainsTypes()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �������� ���������� � �����
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    Assert.IsNotNull(typeInfo.TypeName);
                }
            }
        }
        [Test]
        public void AssemblyInfoContainsNamespaces()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �������� ���������� � ������������� ����
            Assert.IsNotNull(assemblyInfo.Namespaces);
            Assert.IsNotEmpty(assemblyInfo.Namespaces);
        }
        [Test]
        public void AssemblyInfoContainsFields()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �������� ���������� � �����
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var fieldInfo in typeInfo.Fields)
                    {
                        Assert.IsNotNull(fieldInfo.FieldName);
                    }
                }
            }
        }

        [Test]
        public void AssemblyInfoContainsMethods()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �������� ���������� � �������
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var methodInfo in typeInfo.Methods)
                    {
                        Assert.IsNotNull(methodInfo.MethodName);
                    }
                }
            }
        }
        [Test]
        public void AssemblyInfoContainsProperties()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �������� ���������� � ���������
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var propertyInfo in typeInfo.Properties)
                    {
                        Assert.IsNotNull(propertyInfo.PropertyName);
                    }
                }
            }
        }

        [Test]
        public void AssemblyMethodInfoContainsParameters()
        {
            // �������� ���������� � ������
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // ���������, ��� ������ assemblyInfo �������� ���������� � ���������� �������
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var methodInfo in typeInfo.Methods)
                    {
                        foreach (var parameterInfo in methodInfo.Parameters)
                        {
                            Assert.IsNotNull(parameterInfo.FieldName);
                        }
                    }
                }
            }
        }
        // �������������� ����� ����� �������� �������� ������� ���������� � �����, �����, ��������� � �������
        // ��� ����� ����� ������� �������������� ������ �������� � ������ TestAssemblyBrowser
    }
}
