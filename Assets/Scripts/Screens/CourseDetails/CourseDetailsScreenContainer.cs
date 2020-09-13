using ScreenObserver;
using UnityEngine;

namespace Screens.CourseDetails
{
    public class CourseDetailsScreenContainer : MonoBehaviour, ISceneContainer
    {
        public CourseDetailsComponent CourseDetailsComponent;
        public RoomDialogComponent RoomDialogComponent;
    }
}