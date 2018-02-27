using System.ComponentModel;
using System.Runtime.CompilerServices;
using GestionPolicial.Domain.Annotations;

namespace GestionPolicial.Domain.Model.Documentos
{
    public class DocumentoIdentificacionBase : IDocumentoIdentificacion, INotifyPropertyChanged
    {
        public string NumeroDocumento { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}