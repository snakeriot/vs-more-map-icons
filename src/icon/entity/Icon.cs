using Cairo;

namespace MoreMapIcons
{
    /**
     * Interface for all the icons.
     **/
    public interface Icon
    {
        /**
         * Icon rendering logic, only need Context for this, since it's in fact a canvas.
         *
         * @param context - {@link Context}
         **/
        void Render(Context context);

        /**
         * Get width of original icon canvas.
         **/
        float getWidth();

        /**
         * Get height of original icon canvas.
         **/
        float getHeight();
    }
}