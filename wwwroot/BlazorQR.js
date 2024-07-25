export const GenrateQR = (item,id) => new QRious(
        {
             element: document.getElementById(id),
             background: item.background,
             backgroundAlpha: item.backgroundAlpha,
             foreground: item.foreground,
             foregroundAlpha: item.foregroundAlpha,
             level: item.level,
             size: item.size,
             value: item.value,
             padding: item.padding
        }
    );
