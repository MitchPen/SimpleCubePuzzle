using Zenject;

namespace Core.Common.FilesProvider
{
    public class FileProviderInstaller: Installer<FileProviderInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesAndSelfTo<LocalFilesProvider>()
                .AsSingle()
                .NonLazy();
        }
    }
}