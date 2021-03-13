namespace SeewoHelper
{
    public record FileSorterConfig(ExtraFileSortingWay ExtraFileSortingWay, FileSortingInfo[] FileSortingInfos);

    public enum ExtraFileSortingWay
    {
        None,
        Delete
    }
}
